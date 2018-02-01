namespace zPoolMiner.Miners
{
    using System;
    using System.Collections.Generic;
    using zPoolMiner.Configs;
    using zPoolMiner.Enums;
    using zPoolMiner.Miners.Grouping;
    using zPoolMiner.Miners.Parsing;

    /// <summary>
    /// Defines the <see cref="ClaymoreCryptoNightMiner" />
    /// </summary>
    public class ClaymoreCryptoNightMiner : ClaymoreBaseMiner
    {
        /// <summary>
        /// Defines the isOld
        /// </summary>
        private bool isOld;

        /// <summary>
        /// Defines the _LOOK_FOR_START
        /// </summary>
        private const string _LOOK_FOR_START = "XMR - Total Speed:";

        /// <summary>
        /// Defines the _LOOK_FOR_START_OLD
        /// </summary>
        private const string _LOOK_FOR_START_OLD = "hashrate =";

        /// <summary>
        /// Initializes a new instance of the <see cref="ClaymoreCryptoNightMiner"/> class.
        /// </summary>
        /// <param name="isOld">The <see cref="bool"/></param>
        public ClaymoreCryptoNightMiner(bool isOld = false)
            : base("ClaymoreCryptoNightMiner", isOld ? _LOOK_FOR_START_OLD : _LOOK_FOR_START)
        {
            this.isOld = isOld;
        }

        /// <summary>
        /// The DevFee
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        protected override double DevFee()
        {
            return isOld ? 2.0 : 1.0;
        }

        /// <summary>
        /// The GetDevicesCommandString
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        protected override string GetDevicesCommandString()
        {
            if (!isOld) return base.GetDevicesCommandString();

            string extraParams = ExtraLaunchParametersParser.ParseForMiningSetup(MiningSetup, DeviceType.AMD);
            string deviceStringCommand = " -di ";
            List<string> ids = new List<string>();
            foreach (var mPair in MiningSetup.MiningPairs)
            {
                var id = mPair.Device.ID;
                ids.Add(id.ToString());
            }
            deviceStringCommand += String.Join("", ids);

            return deviceStringCommand + extraParams;
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
            if (isOld)
            {
                LastCommandLine = " " + GetDevicesCommandString() + " -mport -" + APIPort + " -o " + url + " -u " +
                                  username + " -p " + worker + " -dbg -1";
            }
            else
            {
                LastCommandLine = " " + GetDevicesCommandString() + " -mport -" + APIPort + " -xpool " + url +
                                  " -xwal " + username + " -xpsw " + worker + " -dbg -1";
            }
            ProcessHandle = _Start();
        }

        // benchmark stuff
        /// <summary>
        /// The BenchmarkCreateCommandLine
        /// </summary>
        /// <param name="algorithm">The <see cref="Algorithm"/></param>
        /// <param name="time">The <see cref="int"/></param>
        /// <returns>The <see cref="string"/></returns>
        protected override string BenchmarkCreateCommandLine(Algorithm algorithm, int time)
        {
            benchmarkTimeWait = time; // Takes longer as of v10

            // network workaround
            string url = Globals.GetLocationURL(algorithm.CryptoMiner937ID, Globals.MiningLocation[ConfigManager.GeneralConfig.ServiceLocation], this.ConectionType);
            // demo for benchmark
            string username = Globals.DemoUser;
            if (ConfigManager.GeneralConfig.WorkerName.Length > 0)
                username += "." + ConfigManager.GeneralConfig.WorkerName.Trim();
            string ret;
            if (isOld)
            {
                ret = " " + GetDevicesCommandString() + " -mport -" + APIPort + " -o " + url + " -u " + username +
                      " -p x";
            }
            else
            {
                ret = " " + GetDevicesCommandString() + " -mport -" + APIPort + " -xpool " + url + " -xwal " +
                             username + " -xpsw x";
            }
            return ret;
        }
    }
}
