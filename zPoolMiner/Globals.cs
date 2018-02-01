namespace zPoolMiner
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using zPoolMiner.Enums;

    /// <summary>
    /// Defines the <see cref="Globals" />
    /// </summary>
    public class Globals
    {
        // Constants
        // Constants        /// <summary>
        /// Defines the MiningLocation
        /// </summary>
        public static string[] MiningLocation = { "zpool", "Ahash", "hk", "jp", "in", "br" };

        /// <summary>
        /// Defines the DemoUser
        /// </summary>
        public static readonly string DemoUser = "1KvnPYf4W7F564hiei1PzFegrD5C1rxHa3";

        // change this if TOS changes
        // change this if TOS changes        /// <summary>
        /// Defines the CURRENT_TOS_VER
        /// </summary>
        public static int CURRENT_TOS_VER = 3;

        // Variables
        // Variables        /// <summary>
        /// Defines the CryptoMiner937Data
        /// </summary>
        public static Dictionary<AlgorithmType, CryptoMiner937API> CryptoMiner937Data = null;

        /// <summary>
        /// Defines the BitcoinUSDRate
        /// </summary>
        public static double BitcoinUSDRate;

        /// <summary>
        /// Defines the JsonSettings
        /// </summary>
        public static JsonSerializerSettings JsonSettings = null;

        /// <summary>
        /// Defines the ThreadsPerCPU
        /// </summary>
        public static int ThreadsPerCPU;

        // quickfix guard for checking internet conection
        // quickfix guard for checking internet conection        /// <summary>
        /// Defines the IsFirstNetworkCheckTimeout
        /// </summary>
        public static bool IsFirstNetworkCheckTimeout = true;

        /// <summary>
        /// Defines the FirstNetworkCheckTimeoutTimeMS
        /// </summary>
        public static int FirstNetworkCheckTimeoutTimeMS = 500;

        /// <summary>
        /// Defines the FirstNetworkCheckTimeoutTries
        /// </summary>
        public static int FirstNetworkCheckTimeoutTries = 10;

        /// <summary>
        /// The GetLocationURL
        /// </summary>
        /// <param name="AlgorithmType">The <see cref="AlgorithmType"/></param>
        /// <param name="miningLocation">The <see cref="string"/></param>
        /// <param name="ConectionType">The <see cref="NHMConectionType"/></param>
        /// <returns>The <see cref="string"/></returns>
        public static string GetLocationURL(AlgorithmType AlgorithmType, string miningLocation, NHMConectionType ConectionType)
        {
            if (Globals.CryptoMiner937Data != null && Globals.CryptoMiner937Data.ContainsKey(AlgorithmType))
            {
                string name = Globals.CryptoMiner937Data[AlgorithmType].name;
                int n_port = Globals.CryptoMiner937Data[AlgorithmType].port;
                int ssl_port = 30000 + n_port;

                // NHMConectionType.NONE
                string prefix = "";
                int port = n_port;
                if (NHMConectionType.LOCKED == ConectionType)
                {
                    return miningLocation;
                }
                if (NHMConectionType.STRATUM_TCP == ConectionType)
                {
                    prefix = "stratum+tcp://";
                }
                if (NHMConectionType.STRATUM_SSL == ConectionType)
                {
                    throw new NotImplementedException("zPool does not support stratum+ssl");
                    //prefix = "stratum+ssl://";
                    //port = ssl_port;
                }

                return prefix
                        + name
                        + ".mine.zpool.ca:"
                        //+ "." + miningLocation
                        //+ ".nicehash.com:"
                        + port;
            }
            return "";
        }

        /// <summary>
        /// The GetBitcoinUser
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        public static string GetBitcoinUser()
        {
            if (BitcoinAddress.ValidateBitcoinAddress((Configs.ConfigManager.GeneralConfig.BitcoinAddress.Trim())))
            {
                return Configs.ConfigManager.GeneralConfig.BitcoinAddress.Trim();
            }
            else
            {
                return DemoUser;
            }
        }
    }
}
