namespace zPoolMiner.Miners
{
    using System.Diagnostics;
    using System.Threading.Tasks;
    using zPoolMiner.Enums;
    using zPoolMiner.Miners.Grouping;
    using zPoolMiner.Miners.Parsing;

    /// <summary>
    /// Defines the <see cref="Cpuminer" />
    /// </summary>
    public class Cpuminer : Miner
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cpuminer"/> class.
        /// </summary>
        public Cpuminer()
            : base("cpuminer_CPU")
        {
        }

        /// <summary>
        /// The GET_MAX_CooldownTimeInMilliseconds
        /// </summary>
        /// <returns>The <see cref="int"/></returns>
        protected override int GET_MAX_CooldownTimeInMilliseconds()
        {
            return 3600000; // 1hour
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

            LastCommandLine = "--algo=" + MiningSetup.MinerName +
                              " --url=" + url +
                              " --userpass=" + username + ":" + worker +
                              ExtraLaunchParametersParser.ParseForMiningSetup(
                                                                MiningSetup,
                                                                DeviceType.CPU) +
                              " --api-bind=" + APIPort.ToString();

            ProcessHandle = _Start();
        }

        /// <summary>
        /// The GetSummaryAsync
        /// </summary>
        /// <returns>The <see cref="Task{APIData}"/></returns>
        public override Task<APIData> GetSummaryAsync()
        {
            return GetSummaryCPU_CCMINERAsync();
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
        /// The _Start
        /// </summary>
        /// <returns>The <see cref="NiceHashProcess"/></returns>
        protected override NiceHashProcess _Start()
        {
            NiceHashProcess P = base._Start();

            var AffinityMask = MiningSetup.MiningPairs[0].Device.AffinityMask;
            if (AffinityMask != 0 && P != null)
                CPUID.AdjustAffinity(P.Id, AffinityMask);

            return P;
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
            return "--algo=" + algorithm.MinerName +
                         " --benchmark" +
                         ExtraLaunchParametersParser.ParseForMiningSetup(
                                                                MiningSetup,
                                                                DeviceType.CPU) +
                         " --time-limit " + time.ToString();
        }

        /// <summary>
        /// The BenchmarkStartProcess
        /// </summary>
        /// <param name="CommandLine">The <see cref="string"/></param>
        /// <returns>The <see cref="Process"/></returns>
        protected override Process BenchmarkStartProcess(string CommandLine)
        {
            Process BenchmarkHandle = base.BenchmarkStartProcess(CommandLine);

            var AffinityMask = MiningSetup.MiningPairs[0].Device.AffinityMask;
            if (AffinityMask != 0 && BenchmarkHandle != null)
                CPUID.AdjustAffinity(BenchmarkHandle.Id, AffinityMask);

            return BenchmarkHandle;
        }

        /// <summary>
        /// The BenchmarkParseLine
        /// </summary>
        /// <param name="outdata">The <see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        protected override bool BenchmarkParseLine(string outdata)
        {
            if (double.TryParse(outdata, out double lastSpeed))
            {
                BenchmarkAlgorithm.BenchmarkSpeed = lastSpeed;
                return true;
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
    }
}
