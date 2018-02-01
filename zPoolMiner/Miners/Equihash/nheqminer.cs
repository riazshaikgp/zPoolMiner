namespace zPoolMiner.Miners
{
    using System.Diagnostics;
    using zPoolMiner.Enums;
    using zPoolMiner.Miners.Parsing;

    /// <summary>
    /// Defines the <see cref="Nheqminer" />
    /// </summary>
    public class Nheqminer : NheqBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Nheqminer"/> class.
        /// </summary>
        public Nheqminer()
            : base("nheqminer")
        {
            ConectionType = NHMConectionType.NONE;
        }

        // CPU aff set from NHM
        /// <summary>
        /// The _Start
        /// </summary>
        /// <returns>The <see cref="NiceHashProcess"/></returns>
        protected override NiceHashProcess _Start()
        {
            NiceHashProcess P = base._Start();
            if (CPU_Setup.IsInit && P != null)
            {
                var AffinityMask = CPU_Setup.MiningPairs[0].Device.AffinityMask;
                if (AffinityMask != 0)
                {
                    CPUID.AdjustAffinity(P.Id, AffinityMask);
                }
            }

            return P;
        }

        /// <summary>
        /// The Start
        /// </summary>
        /// <param name="url">The <see cref="string"/></param>
        /// <param name="btcAdress">The <see cref="string"/></param>
        /// <param name="worker">The <see cref="string"/></param>
        public override void Start(string url, string btcAdress, string worker)
        {
            string username = GetUsername(btcAdress, worker);
            LastCommandLine = GetDevicesCommandString() + " -a " + APIPort + " -l " + url + " -u " + username + " -p " + worker;
            ProcessHandle = _Start();
        }

        /// <summary>
        /// The GetDevicesCommandString
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        protected override string GetDevicesCommandString()
        {
            string deviceStringCommand = " ";

            if (CPU_Setup.IsInit)
            {
                deviceStringCommand += " " + ExtraLaunchParametersParser.ParseForMiningSetup(CPU_Setup, DeviceType.CPU);
            }
            else
            {
                // disable CPU
                deviceStringCommand += " -t 0 ";
            }

            if (NVIDIA_Setup.IsInit)
            {
                deviceStringCommand += " -cd ";
                foreach (var nvidia_pair in NVIDIA_Setup.MiningPairs)
                {
                    deviceStringCommand += nvidia_pair.Device.ID + " ";
                }
                deviceStringCommand += " " + ExtraLaunchParametersParser.ParseForMiningSetup(NVIDIA_Setup, DeviceType.NVIDIA);
            }

            if (AMD_Setup.IsInit)
            {
                deviceStringCommand += " -op " + AMD_OCL_PLATFORM.ToString();
                deviceStringCommand += " -od ";
                foreach (var amd_pair in AMD_Setup.MiningPairs)
                {
                    deviceStringCommand += amd_pair.Device.ID + " ";
                }
                deviceStringCommand += " " + ExtraLaunchParametersParser.ParseForMiningSetup(AMD_Setup, DeviceType.AMD);
            }

            return deviceStringCommand;
        }

        // benchmark stuff
        /// <summary>
        /// The BenchmarkStartProcess
        /// </summary>
        /// <param name="CommandLine">The <see cref="string"/></param>
        /// <returns>The <see cref="Process"/></returns>
        protected override Process BenchmarkStartProcess(string CommandLine)
        {
            Process BenchmarkHandle = base.BenchmarkStartProcess(CommandLine);

            if (CPU_Setup.IsInit && BenchmarkHandle != null)
            {
                var AffinityMask = CPU_Setup.MiningPairs[0].Device.AffinityMask;
                if (AffinityMask != 0)
                {
                    CPUID.AdjustAffinity(BenchmarkHandle.Id, AffinityMask);
                }
            }

            return BenchmarkHandle;
        }

        /// <summary>
        /// The BenchmarkParseLine
        /// </summary>
        /// <param name="outdata">The <see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        protected override bool BenchmarkParseLine(string outdata)
        {
            if (outdata.Contains(Iter_PER_SEC))
            {
                curSpeed = GetNumber(outdata, "Speed: ", Iter_PER_SEC) * SolMultFactor;
            }
            if (outdata.Contains(Sols_PER_SEC))
            {
                var sols = GetNumber(outdata, "Speed: ", Sols_PER_SEC);
                if (sols > 0)
                {
                    BenchmarkAlgorithm.BenchmarkSpeed = curSpeed;
                    return true;
                }
            }
            return false;
        }
    }
}
