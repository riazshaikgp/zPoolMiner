namespace zPoolMiner.Miners
{
    using System;
    using System.Diagnostics;
    using System.Globalization;
    using System.Threading.Tasks;
    using zPoolMiner.Configs;
    using zPoolMiner.Enums;
    using zPoolMiner.Miners.Grouping;
    using zPoolMiner.Miners.Parsing;

    /// <summary>
    /// Defines the <see cref="Palgin_HSR" />
    /// </summary>
    public class Palgin_HSR : Miner
    {
        /// <summary>
        /// Defines the benchmarkTimeWait
        /// </summary>
        private int benchmarkTimeWait = 11 * 60;

        /// <summary>
        /// Defines the DevFee
        /// </summary>
        private const double DevFee = 1.0;

        /// <summary>
        /// Initializes a new instance of the <see cref="Palgin_HSR"/> class.
        /// </summary>
        public Palgin_HSR() : base("Palgin_Neoscrypt_NVIDIA")
        {
        }

        /// <summary>
        /// Gets a value indicating whether BenchmarkException
        /// </summary>
        private bool BenchmarkException
        {
            get
            {
                return MiningSetup.MinerPath == MinerPaths.Data.Palgin_HSR;
            }
        }

        /// <summary>
        /// The GET_MAX_CooldownTimeInMilliseconds
        /// </summary>
        /// <returns>The <see cref="int"/></returns>
        protected override int GET_MAX_CooldownTimeInMilliseconds()
        {
            if (this.MiningSetup.MinerPath == MinerPaths.Data.Palgin_HSR)
            {
                return 60 * 1000 * 11; // wait wait for hashrate string
            }
            return 660 * 1000; // 11 minute max
        }

        /// <summary>
        /// The Start
        /// </summary>
        /// <param name="url">The <see cref="string"/></param>
        /// <param name="btcAdress">The <see cref="string"/></param>
        /// <param name="worker">The <see cref="string"/></param>
        public override void Start(string url, string btcAdress, string worker)
        {
            if (!IsInit)
            {
                Helpers.ConsolePrint(MinerTAG(), "MiningSetup is not initialized exiting Start()");
                return;
            }
            string username = GetUsername(btcAdress, worker);

            IsAPIReadException = MiningSetup.MinerPath == MinerPaths.Data.Palgin_HSR;

            LastCommandLine = " --url=" + url +
                                  " --user=" + btcAdress +
                          " -p " + worker +
                                  ExtraLaunchParametersParser.ParseForMiningSetup(
                                                                MiningSetup,
                                                                DeviceType.NVIDIA) +
                                  " --devices ";
            LastCommandLine += GetDevicesCommandString();
            ProcessHandle = _Start();
        }

        /// <summary>
        /// The _Stop
        /// </summary>
        /// <param name="willswitch">The <see cref="MinerStopType"/></param>
        protected override void _Stop(MinerStopType willswitch)
        {
            Stop_cpu_ccminer_sgminer_nheqminer(willswitch);
        }

        // new decoupled benchmarking routines
        /// <summary>
        /// The BenchmarkCreateCommandLine
        /// </summary>
        /// <param name="algorithm">The <see cref="Algorithm"/></param>
        /// <param name="time">The <see cref="int"/></param>
        /// <returns>The <see cref="string"/></returns>
        protected override string BenchmarkCreateCommandLine(Algorithm algorithm, int time)
        {
            string url = Globals.GetLocationURL(algorithm.CryptoMiner937ID, Globals.MiningLocation[ConfigManager.GeneralConfig.ServiceLocation], this.ConectionType);

            string username = Globals.DemoUser;

            //if (ConfigManager.GeneralConfig.WorkerName.Length > 0)
            //username += "." + ConfigManager.GeneralConfig.WorkerName.Trim();

            string CommandLine = " --url=" + url +
                                  " --user=" + Globals.DemoUser +
                          " -p BENCHMARK " +
                                  ExtraLaunchParametersParser.ParseForMiningSetup(
                                                                MiningSetup,
                                                                DeviceType.NVIDIA) +
                                  " --devices ";
            CommandLine += GetDevicesCommandString();

            Helpers.ConsolePrint(MinerTAG(), CommandLine);

            return CommandLine;
        }

        /// <summary>
        /// The BenchmarkParseLine
        /// </summary>
        /// <param name="outdata">The <see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        protected override bool BenchmarkParseLine(string outdata)
        {
            string hashSpeed = "";
            int kspeed = 1;
            Helpers.ConsolePrint(MinerTAG(), outdata);
            if (BenchmarkException)
            {
                if (outdata.Contains("speed is "))
                {
                    int st = outdata.IndexOf("speed is ");
                    int k = outdata.IndexOf("H/s");
                    if (outdata.Contains("kH/s"))
                    {
                        hashSpeed = outdata.Substring(st + 9, k - st - 10);
                        kspeed = 1000;
                    }
                    if (outdata.Contains("MH/s"))
                    {
                        hashSpeed = outdata.Substring(st + 9, k - st - 10);
                        kspeed = 1000000;
                    }

                    double speed = Double.Parse(hashSpeed, CultureInfo.InvariantCulture);
                    BenchmarkAlgorithm.BenchmarkSpeed = (speed * kspeed) * (1.0 - DevFee * 0.01);
                    BenchmarkSignalFinnished = true;
                }
            }
            return false;
        }

        /// <summary>
        /// The BenchmarkOutputErrorDataReceivedImpl
        /// </summary>
        /// <param name="outdata">The <see cref="string"/></param>
        protected override void BenchmarkOutputErrorDataReceivedImpl(string outdata)
        {
            CheckOutdata(outdata);
        }

        /// <summary>
        /// The GetSummaryAsync
        /// </summary>
        /// <returns>The <see cref="Task{APIData}"/></returns>
        public override async Task<APIData> GetSummaryAsync()
        {
            // CryptoNight does not have api bind port
            APIData hsrData = new APIData(MiningSetup.CurrentAlgorithmType)
            {
                Speed = 0
            };
            if (IsAPIReadException)
            {
                // check if running
                if (ProcessHandle == null)
                {
                    //_currentMinerReadStatus = MinerAPIReadStatus.RESTART;
                    Helpers.ConsolePrint(MinerTAG(), ProcessTag() + " Could not read data from hsrminer Proccess is null");
                    return null;
                }
                try
                {
                    var runningProcess = Process.GetProcessById(ProcessHandle.Id);
                }
                catch (ArgumentException ex)
                {
                    //_currentMinerReadStatus = MinerAPIReadStatus.RESTART;
                    Helpers.ConsolePrint(MinerTAG(), ProcessTag() + " Could not read data from hsrminer reason: " + ex.Message);
                    return null; // will restart outside
                }
                catch (InvalidOperationException ex)
                {
                    //_currentMinerReadStatus = MinerAPIReadStatus.RESTART;
                    Helpers.ConsolePrint(MinerTAG(), ProcessTag() + " Could not read data from hsrminer reason: " + ex.Message);
                    return null; // will restart outside
                }

                var totalSpeed = 0.0d;
                foreach (var miningPair in MiningSetup.MiningPairs)
                {
                    var algo = miningPair.Device.GetAlgorithm(MinerBaseType.Palgin_HSR, AlgorithmType.Hsr, AlgorithmType.NONE);
                    if (algo != null)
                    {
                        totalSpeed += algo.BenchmarkSpeed;
                        Helpers.ConsolePrint(MinerTAG(), ProcessTag() + " Could not read data from hsrminer. Used benchmark hashrate");
                    }
                }

                hsrData.Speed = totalSpeed;
                return hsrData;
            }

            //  return await GetSummaryCPU_Palgin_NeoscryptAsync();
            return hsrData;
        }
    }
}
