﻿namespace zPoolMiner.Miners
{
    using System;
    using System.Diagnostics;
    using System.Globalization;
    using System.Threading;
    using System.Threading.Tasks;
    using zPoolMiner.Configs;
    using zPoolMiner.Devices;
    using zPoolMiner.Enums;
    using zPoolMiner.Miners.Grouping;
    using zPoolMiner.Miners.Parsing;

    /// <summary>
    /// Defines the <see cref="Sgminer" />
    /// </summary>
    internal class Sgminer : Miner
    {
        /// <summary>
        /// Defines the GPUPlatformNumber
        /// </summary>
        private readonly int GPUPlatformNumber;

        /// <summary>
        /// Defines the _benchmarkTimer
        /// </summary>
        private Stopwatch _benchmarkTimer = new Stopwatch();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sgminer"/> class.
        /// </summary>
        public Sgminer()
            : base("sgminer_AMD")
        {
            GPUPlatformNumber = ComputeDeviceManager.Avaliable.AMDOpenCLPlatformNum;
            IsKillAllUsedMinerProcs = true;
        }

        // use ONLY for exiting a benchmark
        /// <summary>
        /// The KillSGMiner
        /// </summary>
        public void KillSGMiner()
        {
            foreach (Process process in Process.GetProcessesByName("sgminer"))
            {
                try { process.Kill(); } catch (Exception e) { Helpers.ConsolePrint(MinerDeviceName, e.ToString()); }
            }
        }

        /// <summary>
        /// The EndBenchmarkProcces
        /// </summary>
        public override void EndBenchmarkProcces()
        {
            if (BenchmarkProcessStatus != BenchmarkProcessStatus.Killing && BenchmarkProcessStatus != BenchmarkProcessStatus.DoneKilling)
            {
                BenchmarkProcessStatus = BenchmarkProcessStatus.Killing;
                try
                {
                    Helpers.ConsolePrint("BENCHMARK", String.Format("Trying to kill benchmark process {0} algorithm {1}", BenchmarkProcessPath, BenchmarkAlgorithm.AlgorithmName));
                    KillSGMiner();
                }
                catch { }
                finally
                {
                    BenchmarkProcessStatus = BenchmarkProcessStatus.DoneKilling;
                    Helpers.ConsolePrint("BENCHMARK", String.Format("Benchmark process {0} algorithm {1} KILLED", BenchmarkProcessPath, BenchmarkAlgorithm.AlgorithmName));
                    //BenchmarkHandle = null;
                }
            }
        }

        /// <summary>
        /// The GET_MAX_CooldownTimeInMilliseconds
        /// </summary>
        /// <returns>The <see cref="int"/></returns>
        protected override int GET_MAX_CooldownTimeInMilliseconds()
        {
            return 90 * 1000; // 1.5 minute max, whole waiting time 75seconds
        }

        /// <summary>
        /// The _Stop
        /// </summary>
        /// <param name="willswitch">The <see cref="MinerStopType"/></param>
        protected override void _Stop(MinerStopType willswitch)
        {
            Stop_cpu_ccminer_sgminer_nheqminer(willswitch);
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

            LastCommandLine = " --gpu-platform " + GPUPlatformNumber +
                              " -k " + MiningSetup.MinerName +
                              " --url=" + url +
                              " --userpass=" + username + ":" + worker + " " +
                              " -p " + worker +
                              " --api-listen" +
                              " --api-port=" + APIPort.ToString() +
                              " " +
                              ExtraLaunchParametersParser.ParseForMiningSetup(
                                                                MiningSetup,
                                                                DeviceType.AMD) +
                              " --device ";

            LastCommandLine += GetDevicesCommandString();

            ProcessHandle = _Start();
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
            string CommandLine;

            string url = Globals.GetLocationURL(algorithm.CryptoMiner937ID, Globals.MiningLocation[ConfigManager.GeneralConfig.ServiceLocation], this.ConectionType);

            // demo for benchmark
            string username = Globals.DemoUser;

            if (ConfigManager.GeneralConfig.WorkerName.Length > 0)
                username += "." + ConfigManager.GeneralConfig.WorkerName.Trim();

            // cd to the cgminer for the process bins
            CommandLine = " /C \"cd /d " + WorkingDirectory + " && sgminer.exe " +
                          " --gpu-platform " + GPUPlatformNumber +
                          " -k " + algorithm.MinerName +
                          " --url=" + url +
                          " --userpass=" + username +
                          " -p Benchmark " +
                          " --sched-stop " + DateTime.Now.AddSeconds(time).ToString("HH:mm") +
                          " -T --log 10 --log-file dump.txt" +
                          " " +
                          ExtraLaunchParametersParser.ParseForMiningSetup(
                                                                MiningSetup,
                                                                DeviceType.AMD) +
                          " --device ";

            CommandLine += GetDevicesCommandString();

            CommandLine += " && del dump.txt\"";

            return CommandLine;
        }

        /// <summary>
        /// The BenchmarkParseLine
        /// </summary>
        /// <param name="outdata">The <see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        protected override bool BenchmarkParseLine(string outdata)
        {
            if (outdata.Contains("Average hashrate:") && outdata.Contains("/s") && BenchmarkAlgorithm.CryptoMiner937ID != AlgorithmType.DaggerHashimoto)
            {
                int i = outdata.IndexOf(": ");
                int k = outdata.IndexOf("/s");

                // save speed
                string hashSpeed = outdata.Substring(i + 2, k - i + 2);
                Helpers.ConsolePrint("BENCHMARK", "Final Speed: " + hashSpeed);

                hashSpeed = hashSpeed.Substring(0, hashSpeed.IndexOf(" "));
                double speed = Double.Parse(hashSpeed, CultureInfo.InvariantCulture);

                if (outdata.Contains("Kilohash"))
                    speed *= 1000;
                else if (outdata.Contains("Megahash"))
                    speed *= 1000000;

                BenchmarkAlgorithm.BenchmarkSpeed = speed;
                return true;
            }
            else if (outdata.Contains(String.Format("GPU{0}", MiningSetup.MiningPairs[0].Device.ID)) && outdata.Contains("s):") && BenchmarkAlgorithm.CryptoMiner937ID == AlgorithmType.DaggerHashimoto)
            {
                int i = outdata.IndexOf("s):");
                int k = outdata.IndexOf("(avg)");

                // save speed
                string hashSpeed = outdata.Substring(i + 3, k - i + 3).Trim();
                hashSpeed = hashSpeed.Replace("(avg):", "");
                Helpers.ConsolePrint("BENCHMARK", "Final Speed: " + hashSpeed);

                double mult = 1;
                if (hashSpeed.Contains("K"))
                {
                    hashSpeed = hashSpeed.Replace("K", " ");
                    mult = 1000;
                }
                else if (hashSpeed.Contains("M"))
                {
                    hashSpeed = hashSpeed.Replace("M", " ");
                    mult = 1000000;
                }

                hashSpeed = hashSpeed.Substring(0, hashSpeed.IndexOf(" "));
                double speed = Double.Parse(hashSpeed, CultureInfo.InvariantCulture) * mult;

                BenchmarkAlgorithm.BenchmarkSpeed = speed;

                return true;
            }
            return false;
        }

        /// <summary>
        /// The BenchmarkThreadRoutineStartSettup
        /// </summary>
        protected override void BenchmarkThreadRoutineStartSettup()
        {
            // sgminer extra settings
            AlgorithmType NHDataIndex = BenchmarkAlgorithm.CryptoMiner937ID;

            if (Globals.CryptoMiner937Data == null)
            {
                Helpers.ConsolePrint("BENCHMARK", "Skipping sgminer benchmark because there is no internet " +
                    "connection. Sgminer needs internet connection to do benchmarking.");

                throw new Exception("No internet connection");
            }

            if (Globals.CryptoMiner937Data[NHDataIndex].paying == 0)
            {
                Helpers.ConsolePrint("BENCHMARK", "Skipping sgminer benchmark because there is no work on Nicehash.com " +
                    "[algo: " + BenchmarkAlgorithm.AlgorithmName + "(" + NHDataIndex + ")]");

                throw new Exception("No work can be used for benchmarking");
            }

            _benchmarkTimer.Reset();
            _benchmarkTimer.Start();
        }

        /// <summary>
        /// The BenchmarkOutputErrorDataReceivedImpl
        /// </summary>
        /// <param name="outdata">The <see cref="string"/></param>
        protected override void BenchmarkOutputErrorDataReceivedImpl(string outdata)
        {
            if (_benchmarkTimer.Elapsed.TotalSeconds >= BenchmarkTimeInSeconds)
            {
                string resp = GetAPIDataAsync(APIPort, "quit").Result.TrimEnd(new char[] { (char)0 });
                Helpers.ConsolePrint("BENCHMARK", "SGMiner Response: " + resp);
            }
            if (_benchmarkTimer.Elapsed.TotalSeconds >= BenchmarkTimeInSeconds + 2)
            {
                _benchmarkTimer.Stop();
                // this is safe in a benchmark
                KillSGMiner();
                BenchmarkSignalHanged = true;
            }
            if (!BenchmarkSignalFinnished && outdata != null)
            {
                CheckOutdata(outdata);
            }
        }

        /// <summary>
        /// The GetFinalBenchmarkString
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        protected override string GetFinalBenchmarkString()
        {
            if (BenchmarkAlgorithm.BenchmarkSpeed <= 0)
            {
                Helpers.ConsolePrint("sgminer_GetFinalBenchmarkString", International.GetText("sgminer_precise_try"));
                return International.GetText("sgminer_precise_try");
            }
            return base.GetFinalBenchmarkString();
        }

        /// <summary>
        /// The BenchmarkThreadRoutine
        /// </summary>
        /// <param name="CommandLine">The <see cref="object"/></param>
        protected override void BenchmarkThreadRoutine(object CommandLine)
        {
            Thread.Sleep(ConfigManager.GeneralConfig.MinerRestartDelayMS * 3); // increase wait for sgminer

            BenchmarkSignalQuit = false;
            BenchmarkSignalHanged = false;
            BenchmarkSignalFinnished = false;
            BenchmarkException = null;

            try
            {
                Helpers.ConsolePrint("BENCHMARK", "Benchmark starts");
                BenchmarkHandle = BenchmarkStartProcess((string)CommandLine);
                BenchmarkThreadRoutineStartSettup();
                // wait a little longer then the benchmark routine if exit false throw
                //var timeoutTime = BenchmarkTimeoutInSeconds(BenchmarkTimeInSeconds);
                //var exitSucces = BenchmarkHandle.WaitForExit(timeoutTime * 1000);
                // don't use wait for it breaks everything
                BenchmarkProcessStatus = BenchmarkProcessStatus.Running;
                while (true)
                {
                    string outdata = BenchmarkHandle.StandardOutput.ReadLine();
                    BenchmarkOutputErrorDataReceivedImpl(outdata);
                    // terminate process situations
                    if (BenchmarkSignalQuit
                        || BenchmarkSignalFinnished
                        || BenchmarkSignalHanged
                        || BenchmarkSignalTimedout
                        || BenchmarkException != null)
                    {
                        //EndBenchmarkProcces();
                        // this is safe in a benchmark
                        KillSGMiner();
                        if (BenchmarkSignalTimedout)
                        {
                            throw new Exception("Benchmark timedout");
                        }
                        if (BenchmarkException != null)
                        {
                            throw BenchmarkException;
                        }
                        if (BenchmarkSignalQuit)
                        {
                            throw new Exception("Termined by user request");
                        }
                        if (BenchmarkSignalHanged)
                        {
                            throw new Exception("SGMiner is not responding");
                        }
                        if (BenchmarkSignalFinnished)
                        {
                            break;
                        }
                    }
                    else
                    {
                        // wait a second reduce CPU load
                        Thread.Sleep(1000);
                    }
                }
            }
            catch (Exception ex)
            {
                BenchmarkThreadRoutineCatch(ex);
            }
            finally
            {
                BenchmarkThreadRoutineFinish();
            }
        }

        // TODO _currentMinerReadStatus
        /// <summary>
        /// The GetSummaryAsync
        /// </summary>
        /// <returns>The <see cref="Task{APIData}"/></returns>
        public override async Task<APIData> GetSummaryAsync()
        {
            string resp;
            APIData ad = new APIData(MiningSetup.CurrentAlgorithmType);

            resp = await GetAPIDataAsync(APIPort, "summary");
            if (resp == null)
            {
                _currentMinerReadStatus = MinerAPIReadStatus.NONE;
                return null;
            }
            //// sgminer debug log
            //Helpers.ConsolePrint("sgminer-DEBUG_resp", resp);

            try
            {
                // Checks if all the GPUs are Alive first
                string resp2 = await GetAPIDataAsync(APIPort, "devs");
                if (resp2 == null)
                {
                    _currentMinerReadStatus = MinerAPIReadStatus.NONE;
                    return null;
                }
                //// sgminer debug log
                //Helpers.ConsolePrint("sgminer-DEBUG_resp2", resp2);

                string[] checkGPUStatus = resp2.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 1; i < checkGPUStatus.Length - 1; i++)
                {
                    if (checkGPUStatus[i].Contains("Enabled=Y") && !checkGPUStatus[i].Contains("Status=Alive"))
                    {
                        Helpers.ConsolePrint(MinerTAG(), ProcessTag() + " GPU " + i + ": Sick/Dead/NoStart/Initialising/Disabled/Rejecting/Unknown");
                        _currentMinerReadStatus = MinerAPIReadStatus.WAIT;
                        return null;
                    }
                }

                string[] resps = resp.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                if (resps[1].Contains("SUMMARY"))
                {
                    string[] data = resps[1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                    // Get miner's current total speed
                    string[] speed = data[4].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                    // Get miner's current total MH
                    double total_mh = Double.Parse(data[18].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries)[1], new CultureInfo("en-US"));

                    ad.Speed = Double.Parse(speed[1]) * 1000;

                    if (total_mh <= PreviousTotalMH)
                    {
                        Helpers.ConsolePrint(MinerTAG(), ProcessTag() + " SGMiner might be stuck as no new hashes are being produced");
                        Helpers.ConsolePrint(MinerTAG(), ProcessTag() + " Prev Total MH: " + PreviousTotalMH + " .. Current Total MH: " + total_mh);
                        _currentMinerReadStatus = MinerAPIReadStatus.NONE;
                        return null;
                    }

                    PreviousTotalMH = total_mh;
                }
                else
                {
                    ad.Speed = 0;
                }
            }
            catch
            {
                _currentMinerReadStatus = MinerAPIReadStatus.NONE;
                return null;
            }

            _currentMinerReadStatus = MinerAPIReadStatus.GOT_READ;
            // check if speed zero
            if (ad.Speed == 0) _currentMinerReadStatus = MinerAPIReadStatus.READ_SPEED_ZERO;

            return ad;
        }
    }
}
