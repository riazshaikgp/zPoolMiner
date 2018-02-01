﻿namespace zPoolMiner.Miners.Grouping
{
    using System.Collections.Generic;
    using zPoolMiner.Enums;

    /// <summary>
    /// Defines the <see cref="MiningSetup" />
    /// </summary>
    public class MiningSetup
    {
        /// <summary>
        /// Gets or sets the MiningPairs
        /// </summary>
        public List<MiningPair> MiningPairs { get; private set; }

        /// <summary>
        /// Gets or sets the MinerPath
        /// </summary>
        public string MinerPath { get; private set; }

        /// <summary>
        /// Gets or sets the MinerName
        /// </summary>
        public string MinerName { get; private set; }

        /// <summary>
        /// Gets or sets the CurrentAlgorithmType
        /// </summary>
        public AlgorithmType CurrentAlgorithmType { get; private set; }

        /// <summary>
        /// Gets or sets the CurrentSecondaryAlgorithmType
        /// </summary>
        public AlgorithmType CurrentSecondaryAlgorithmType { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsInit
        /// </summary>
        public bool IsInit { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MiningSetup"/> class.
        /// </summary>
        /// <param name="miningPairs">The <see cref="List{MiningPair}"/></param>
        public MiningSetup(List<MiningPair> miningPairs)
        {
            this.IsInit = false;
            this.CurrentAlgorithmType = AlgorithmType.NONE;
            if (miningPairs != null && miningPairs.Count > 0)
            {
                this.MiningPairs = miningPairs;
                this.MiningPairs.Sort((a, b) => a.Device.ID - b.Device.ID);
                this.MinerName = miningPairs[0].Algorithm.MinerName;
                this.CurrentAlgorithmType = miningPairs[0].Algorithm.CryptoMiner937ID;
                this.CurrentSecondaryAlgorithmType = miningPairs[0].Algorithm.SecondaryCryptoMiner937ID;
                this.MinerPath = miningPairs[0].Algorithm.MinerBinaryPath;
                this.IsInit = MinerPaths.IsValidMinerPath(this.MinerPath);
            }
        }
    }
}
