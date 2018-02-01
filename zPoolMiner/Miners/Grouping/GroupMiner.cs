namespace zPoolMiner.Miners.Grouping
{
    using System;
    using System.Collections.Generic;
    using zPoolMiner.Configs;
    using zPoolMiner.Enums;

    /// <summary>
    /// Defines the <see cref="GroupMiner" />
    /// </summary>
    public class GroupMiner
    {
        /// <summary>
        /// Gets or sets the Miner
        /// </summary>
        public Miner Miner { get; protected set; }

        /// <summary>
        /// Gets or sets the DevicesInfoString
        /// </summary>
        public string DevicesInfoString { get; private set; }

        /// <summary>
        /// Gets or sets the AlgorithmType
        /// </summary>
        public AlgorithmType AlgorithmType { get; private set; }

        /// <summary>
        /// Gets or sets the DualAlgorithmType
        /// </summary>
        public AlgorithmType DualAlgorithmType { get; private set; }

        // for now used only for dagger identification AMD or NVIDIA

        // for now used only for dagger identification AMD or NVIDIA
        /// <summary>
        /// Gets or sets the DeviceType
        /// </summary>
        public DeviceType DeviceType { get; private set; }

        /// <summary>
        /// Gets or sets the CurrentRate
        /// </summary>
        public double CurrentRate { get; set; }

        /// <summary>
        /// Gets or sets the Key
        /// </summary>
        public string Key { get; private set; }

        /// <summary>
        /// Gets or sets the DevIndexes
        /// </summary>
        public List<int> DevIndexes { get; private set; }

        // , string miningLocation, string btcAdress, string worker
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupMiner"/> class.
        /// </summary>
        /// <param name="miningPairs">The <see cref="List{MiningPair}"/></param>
        /// <param name="key">The <see cref="string"/></param>
        public GroupMiner(List<MiningPair> miningPairs, string key)
        {
            AlgorithmType = AlgorithmType.NONE;
            DualAlgorithmType = AlgorithmType.NONE;
            DevicesInfoString = "N/A";
            CurrentRate = 0;
            Key = key;
            if (miningPairs.Count > 0)
            {
                // sort pairs by device id
                miningPairs.Sort((a, b) => a.Device.ID - b.Device.ID);
                // init name scope and IDs
                {
                    List<string> deviceNames = new List<string>();
                    DevIndexes = new List<int>();
                    foreach (var pair in miningPairs)
                    {
                        deviceNames.Add(pair.Device.NameCount);
                        DevIndexes.Add(pair.Device.Index);
                    }
                    DevicesInfoString = "{ " + String.Join(", ", deviceNames) + " }";
                }
                // init miner
                {
                    var mPair = miningPairs[0];
                    DeviceType = mPair.Device.DeviceType;
                    Miner = MinerFactory.CreateMiner(mPair.Device, mPair.Algorithm);
                    if (Miner != null)
                    {
                        Miner.InitMiningSetup(new MiningSetup(miningPairs));
                        AlgorithmType = mPair.Algorithm.CryptoMiner937ID;
                        DualAlgorithmType = mPair.Algorithm.DualCryptoMiner937ID();
                    }
                }
            }
        }

        /// <summary>
        /// The Stop
        /// </summary>
        public void Stop()
        {
            if (Miner != null && Miner.IsRunning)
            {
                Miner.Stop(MinerStopType.SWITCH);
                // wait before going on
                System.Threading.Thread.Sleep(ConfigManager.GeneralConfig.MinerRestartDelayMS);
            }
            CurrentRate = 0;
        }

        /// <summary>
        /// The End
        /// </summary>
        public void End()
        {
            if (Miner != null)
            {
                Miner.End();
            }
            CurrentRate = 0;
        }

        /// <summary>
        /// The Start
        /// </summary>
        /// <param name="miningLocation">The <see cref="string"/></param>
        /// <param name="btcAdress">The <see cref="string"/></param>
        /// <param name="worker">The <see cref="string"/></param>
        public void Start(string miningLocation, string btcAdress, string worker)
        {
            if (Miner.IsRunning)
            {
                return;
            }
            // Wait before new start
            System.Threading.Thread.Sleep(ConfigManager.GeneralConfig.MinerRestartDelayMS);
            string locationURL = Globals.GetLocationURL(AlgorithmType, miningLocation, Miner.ConectionType);
            Miner.Start(locationURL, btcAdress, worker);
        }
    }
}
