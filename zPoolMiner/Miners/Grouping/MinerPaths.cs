namespace zPoolMiner.Miners.Grouping
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using zPoolMiner.Configs.ConfigJsonFile;
    using zPoolMiner.Devices;
    using zPoolMiner.Enums;

    /// <summary>
    /// Defines the <see cref="MinerPathPackageFile" />
    /// </summary>
    internal class MinerPathPackageFile : ConfigFile<MinerPathPackage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MinerPathPackageFile"/> class.
        /// </summary>
        /// <param name="name">The <see cref="string"/></param>
        public MinerPathPackageFile(string name)
            : base(FOLDERS.INTERNALS, String.Format("{0}.json", name), String.Format("{0}_old.json", name))
        {
        }
    }

    /// <summary>
    /// Defines the <see cref="MinerPathPackage" />
    /// </summary>
    public class MinerPathPackage
    {
        /// <summary>
        /// Defines the Name
        /// </summary>
        public string Name;

        /// <summary>
        /// Defines the DeviceType
        /// </summary>
        public DeviceGroupType DeviceType;

        /// <summary>
        /// Defines the MinerTypes
        /// </summary>
        public List<MinerTypePath> MinerTypes;

        /// <summary>
        /// Initializes a new instance of the <see cref="MinerPathPackage"/> class.
        /// </summary>
        /// <param name="type">The <see cref="DeviceGroupType"/></param>
        /// <param name="paths">The <see cref="List{MinerTypePath}"/></param>
        public MinerPathPackage(DeviceGroupType type, List<MinerTypePath> paths)
        {
            DeviceType = type;
            MinerTypes = paths;
            Name = DeviceType.ToString();
        }
    }

    /// <summary>
    /// Defines the <see cref="MinerTypePath" />
    /// </summary>
    public class MinerTypePath
    {
        /// <summary>
        /// Defines the Name
        /// </summary>
        public string Name;

        /// <summary>
        /// Defines the Type
        /// </summary>
        public MinerBaseType Type;

        /// <summary>
        /// Defines the Algorithms
        /// </summary>
        public List<MinerPath> Algorithms;

        /// <summary>
        /// Initializes a new instance of the <see cref="MinerTypePath"/> class.
        /// </summary>
        /// <param name="type">The <see cref="MinerBaseType"/></param>
        /// <param name="paths">The <see cref="List{MinerPath}"/></param>
        public MinerTypePath(MinerBaseType type, List<MinerPath> paths)
        {
            Type = type;
            Algorithms = paths;
            Name = type.ToString();
        }
    }

    /// <summary>
    /// Defines the <see cref="MinerPath" />
    /// </summary>
    public class MinerPath
    {
        /// <summary>
        /// Defines the Name
        /// </summary>
        public string Name;

        /// <summary>
        /// Defines the Algorithm
        /// </summary>
        public AlgorithmType Algorithm;

        /// <summary>
        /// Defines the Path
        /// </summary>
        public string Path;

        /// <summary>
        /// Initializes a new instance of the <see cref="MinerPath"/> class.
        /// </summary>
        /// <param name="algo">The <see cref="AlgorithmType"/></param>
        /// <param name="path">The <see cref="string"/></param>
        public MinerPath(AlgorithmType algo, string path)
        {
            Algorithm = algo;
            Path = path;
            Name = Algorithm.ToString();
        }
    }

    /// <summary>
    /// MinerPaths, used just to store miners paths strings. Only one instance needed
    /// </summary>
    public static class MinerPaths
    {
        /// <summary>
        /// Defines the <see cref="Data" />
        /// </summary>
        public static class Data
        {
            // root binary folder
            // root binary folder            /// <summary>
            /// Defines the _bin
            /// </summary>
            private const string _bin = @"bin";

            /// <summary>
            /// ccminers
            /// </summary>
            public const string ccminer_22 = _bin + @"\ccminer_22\ccminer.exe";

            /// <summary>
            /// Defines the ccminer_alexis_hsr
            /// </summary>
            public const string ccminer_alexis_hsr = _bin + @"\ccminer_alexis_hsr\ccminer.exe";

            /// <summary>
            /// Defines the ccminer_alexis78
            /// </summary>
            public const string ccminer_alexis78 = _bin + @"\ccminer_alexis78\ccminer.exe";

            /// <summary>
            /// Defines the ccminer_cryptonight
            /// </summary>
            public const string ccminer_cryptonight = _bin + @"\ccminer_cryptonight\ccminer.exe";

            /// <summary>
            /// Defines the ccminer_decred
            /// </summary>
            public const string ccminer_decred = _bin + @"\ccminer_decred\ccminer.exe";

            /// <summary>
            /// Defines the ccminer_klaust
            /// </summary>
            public const string ccminer_klaust = _bin + @"\ccminer_klaust\ccminer.exe";

            /// <summary>
            /// Defines the ccminer_klaust818
            /// </summary>
            public const string ccminer_klaust818 = _bin + @"\ccminer_klaust818\ccminer.exe";

            /// <summary>
            /// Defines the ccminer_nanashi
            /// </summary>
            public const string ccminer_nanashi = _bin + @"\ccminer_nanashi\ccminer.exe";

            /// <summary>
            /// Defines the ccminer_neoscrypt
            /// </summary>
            public const string ccminer_neoscrypt = _bin + @"\ccminer_neoscrypt\ccminer.exe";

            /// <summary>
            /// Defines the ccminer_palgin
            /// </summary>
            public const string ccminer_palgin = _bin + @"\ccminer_palgin\ccminer.exe";

            /// <summary>
            /// Defines the ccminer_polytimos
            /// </summary>
            public const string ccminer_polytimos = _bin + @"\ccminer_polytimos\ccminer.exe";

            /// <summary>
            /// Defines the ccminer_skunkkrnlx
            /// </summary>
            public const string ccminer_skunkkrnlx = _bin + @"\ccminer_skunkkrnlx\ccminer.exe";

            /// <summary>
            /// Defines the ccminer_sp
            /// </summary>
            public const string ccminer_sp = _bin + @"\ccminer_sp\ccminer.exe";

            /// <summary>
            /// Defines the ccminer_tpruvot
            /// </summary>
            public const string ccminer_tpruvot = _bin + @"\ccminer_tpruvot\ccminer.exe";

            /// <summary>
            /// Defines the ccminer_tpruvot2
            /// </summary>
            public const string ccminer_tpruvot2 = _bin + @"\ccminer_tpruvot2\ccminer.exe";

            /// <summary>
            /// Defines the ccminer_x11gost
            /// </summary>
            public const string ccminer_x11gost = _bin + @"\ccminer_x11gost\ccminer.exe";

            /// <summary>
            /// Defines the ccminer_xevan
            /// </summary>
            public const string ccminer_xevan = _bin + @"\ccminer_xevan\ccminer.exe";

            /// <summary>
            /// CPUminers
            /// </summary>
            public const string cpuminer_opt_AES = _bin + @"\cpuminer_opt_AES.exe";

            /// <summary>
            /// Defines the cpuminer_opt_AVX
            /// </summary>
            public const string cpuminer_opt_AVX = _bin + @"\cpuminer_opt_AVX.exe";

            /// <summary>
            /// Defines the cpuminer_opt_AVX2
            /// </summary>
            public const string cpuminer_opt_AVX2 = _bin + @"\cpuminer_opt_AVX2.exe";

            /// <summary>
            /// Defines the cpuminer_opt_AVX2_AES
            /// </summary>
            public const string cpuminer_opt_AVX2_AES = _bin + @"\cpuminer_opt_AVX2_AES.exe";

            /// <summary>
            /// Defines the cpuminer_opt_AVX_AES
            /// </summary>
            public const string cpuminer_opt_AVX_AES = _bin + @"\cpuminer_opt_AVX_AES.exe";

            /// <summary>
            /// Defines the cpuminer_opt_SSE2
            /// </summary>
            public const string cpuminer_opt_SSE2 = _bin + @"\cpuminer_opt_SSE2.exe";

            /// <summary>
            /// ethminers
            /// </summary>
            public const string ethminer = _bin + @"\ethminer\ethminer.exe";

            /// <summary>
            /// sgminers
            /// </summary>
            public const string sgminer_5_6_0_general = _bin + @"\sgminer-5-6-0-general\sgminer.exe";

            /// <summary>
            /// Defines the sgminer_gm
            /// </summary>
            public const string sgminer_gm = _bin + @"\sgminer-gm\sgminer.exe";

            /// <summary>
            /// Defines the sgminer_HSR
            /// </summary>
            public const string sgminer_HSR = _bin + @"\sgminer-HSR\sgminer.exe";

            /// <summary>
            /// Defines the sgminer_Phi
            /// </summary>
            public const string sgminer_Phi = _bin + @"\sgminer-Phi\sgminer.exe";

            /// <summary>
            /// Defines the sgminer_Bitcore
            /// </summary>
            public const string sgminer_Bitcore = _bin + @"\sgminer-Bitcore\sgminer.exe";

            /// <summary>
            /// Defines the sgminer_Skein
            /// </summary>
            public const string sgminer_Skein = _bin + @"\sgminer-Skein\sgminer.exe";

            /// <summary>
            /// Defines the sgminer_Tribus
            /// </summary>
            public const string sgminer_Tribus = _bin + @"\sgminer-Tribus\sgminer.exe";

            /// <summary>
            /// Defines the sgminer_Xevan
            /// </summary>
            public const string sgminer_Xevan = _bin + @"\sgminer-Xevan\sgminer.exe";

            /// <summary>
            /// Defines the glg
            /// </summary>
            public const string glg = _bin + @"\glg\gatelessgate.exe";

            /// <summary>
            /// Defines the nheqminer
            /// </summary>
            public const string nheqminer = _bin + @"\nheqminer_v0.4b\nheqminer.exe";

            /// <summary>
            /// Defines the excavator
            /// </summary>
            public const string excavator = _bin + @"\excavator\excavator.exe";

            /// <summary>
            /// Defines the XmrStackCPUMiner
            /// </summary>
            public const string XmrStackCPUMiner = _bin + @"\xmr-stak-cpu\xmr-stak-cpu.exe";

            /// <summary>
            /// Defines the XmrStakAMD
            /// </summary>
            public const string XmrStakAMD = _bin + @"\xmr-stak-amd\xmr-stak-amd.exe";

            /// <summary>
            /// Defines the Xmrig
            /// </summary>
            public const string Xmrig = _bin + @"\xmrig\xmrig.exe";

            /// <summary>
            /// Defines the NONE
            /// </summary>
            public const string NONE = "";

            // root binary folder
            // root binary folder            /// <summary>
            /// Defines the _bin_3rdparty
            /// </summary>
            private const string _bin_3rdparty = @"bin_3rdparty";

            /// <summary>
            /// Defines the ClaymoreZcashMiner
            /// </summary>
            public const string ClaymoreZcashMiner = _bin_3rdparty + @"\claymore_zcash\ZecMiner64.exe";

            /// <summary>
            /// Defines the ClaymoreCryptoNightMiner
            /// </summary>
            public const string ClaymoreCryptoNightMiner = _bin_3rdparty + @"\claymore_cryptonight\NsGpuCNMiner.exe";

            /// <summary>
            /// Defines the ClaymoreCryptoNightMiner_old
            /// </summary>
            public const string ClaymoreCryptoNightMiner_old = _bin_3rdparty + @"\claymore_cryptonight_old\NsGpuCNMiner.exe";

            /// <summary>
            /// Defines the OptiminerZcashMiner
            /// </summary>
            public const string OptiminerZcashMiner = _bin_3rdparty + @"\optiminer_zcash_win\Optiminer.exe";

            /// <summary>
            /// Defines the ClaymoreDual
            /// </summary>
            public const string ClaymoreDual = _bin_3rdparty + @"\claymore_dual\EthDcrMiner64.exe";

            /// <summary>
            /// Defines the EWBF
            /// </summary>
            public const string EWBF = _bin_3rdparty + @"\ewbf\miner.exe";

            /// <summary>
            /// Defines the DSTM
            /// </summary>
            public const string DSTM = _bin_3rdparty + @"\dstm\zm.exe";

            /// <summary>
            /// Defines the Palgin_Neoscrypt
            /// </summary>
            public const string Palgin_Neoscrypt = _bin_3rdparty + @"\hsrminer_neoscrypt\hsrminer_neoscrypt.exe";

            /// <summary>
            /// Defines the Palgin_HSR
            /// </summary>
            public const string Palgin_HSR = _bin_3rdparty + @"\hsrminer_neoscrypt\hsrminer_hsr.exe";

            /// <summary>
            /// Defines the prospector
            /// </summary>
            public const string prospector = _bin_3rdparty + @"\prospector\prospector.exe";

            /// <summary>
            /// Defines the mkxminer
            /// </summary>
            public const string mkxminer = _bin_3rdparty + @"\mkxminer\mkxminer.exe";
        }

        // NEW START
        ////////////////////////////////////////////
        // Pure functions
        //public static bool IsMinerAlgorithmAvaliable(List<Algorithm> algos, MinerBaseType minerBaseType, AlgorithmType algorithmType) {
        //    return algos.FindIndex((a) => a.MinerBaseType == minerBaseType && a.CryptoMiner937ID == algorithmType) > -1;
        //}
        /// <summary>
        /// The GetPathFor
        /// </summary>
        /// <param name="minerBaseType">The <see cref="MinerBaseType"/></param>
        /// <param name="algoType">The <see cref="AlgorithmType"/></param>
        /// <param name="devGroupType">The <see cref="DeviceGroupType"/></param>
        /// <param name="def">The <see cref="bool"/></param>
        /// <returns>The <see cref="string"/></returns>
        public static string GetPathFor(MinerBaseType minerBaseType, AlgorithmType algoType, DeviceGroupType devGroupType, bool def = false)
        {
            if (!def & configurableMiners.Contains(minerBaseType))
            {
                // Override with internals
                var path = minerPathPackages.Find(p => p.DeviceType == devGroupType)
                    .MinerTypes.Find(p => p.Type == minerBaseType)
                    .Algorithms.Find(p => p.Algorithm == algoType);
                if (path != null)
                {
                    if (File.Exists(path.Path))
                    {
                        return path.Path;
                    }
                    else
                    {
                        Helpers.ConsolePrint("PATHS", String.Format("Path {0} not found, using defaults", path.Path));
                    }
                }
            }
            switch (minerBaseType)
            {
                case MinerBaseType.cpuminer:
                    return Data.cpuminer_opt_AVX_AES;

                case MinerBaseType.ccminer:
                    return NVIDIA_GROUPS.Ccminer_path(algoType, devGroupType);

                case MinerBaseType.ccminer_22:
                    return NVIDIA_GROUPS.Ccminer_path(algoType, devGroupType);

                case MinerBaseType.ccminer_alexis_hsr:
                    return NVIDIA_GROUPS.Ccminer_path(algoType, devGroupType);

                case MinerBaseType.ccminer_alexis78:
                    return NVIDIA_GROUPS.Ccminer_path(algoType, devGroupType);

                case MinerBaseType.ccminer_klaust818:
                    return NVIDIA_GROUPS.Ccminer_path(algoType, devGroupType);

                case MinerBaseType.ccminer_palgin:
                    return NVIDIA_GROUPS.Ccminer_path(algoType, devGroupType);

                case MinerBaseType.ccminer_polytimos:
                    return NVIDIA_GROUPS.Ccminer_path(algoType, devGroupType);

                case MinerBaseType.ccminer_skunkkrnlx:
                    return NVIDIA_GROUPS.Ccminer_path(algoType, devGroupType);

                case MinerBaseType.ccminer_xevan:
                    return NVIDIA_GROUPS.Ccminer_path(algoType, devGroupType);

                case MinerBaseType.ccminer_tpruvot2:
                    return NVIDIA_GROUPS.Ccminer_path(algoType, devGroupType);

                case MinerBaseType.sgminer:
                    return AMD_GROUP.Sgminer_path(algoType);

                case MinerBaseType.GatelessGate:
                    return AMD_GROUP.Glg_path(algoType);

                case MinerBaseType.nheqminer:
                    return Data.nheqminer;

                case MinerBaseType.ethminer:
                    return Data.ethminer;

                case MinerBaseType.Claymore:
                    return AMD_GROUP.ClaymorePath(algoType);

                case MinerBaseType.OptiminerAMD:
                    return Data.OptiminerZcashMiner;

                case MinerBaseType.excavator:
                    return Data.excavator;

                case MinerBaseType.XmrStackCPU:
                    return Data.XmrStackCPUMiner;

                case MinerBaseType.ccminer_alexis:
                    return NVIDIA_GROUPS.Ccminer_unstable_path(algoType, devGroupType);

                case MinerBaseType.experimental:
                    return EXPERIMENTAL.GetPath(algoType, devGroupType);

                case MinerBaseType.EWBF:
                    return Data.EWBF;

                case MinerBaseType.DSTM:
                    return Data.DSTM;

                case MinerBaseType.Prospector:
                    return Data.prospector;

                case MinerBaseType.Xmrig:
                    return Data.Xmrig;

                case MinerBaseType.XmrStakAMD:
                    return Data.XmrStakAMD;

                case MinerBaseType.Claymore_old:
                    return Data.ClaymoreCryptoNightMiner_old;

                case MinerBaseType.Palgin_Neoscrypt:
                    return NVIDIA_GROUPS.Palgin_Neoscrypt_path(algoType, devGroupType);

                case MinerBaseType.Palgin_HSR:
                    return NVIDIA_GROUPS.Palgin_HSR_path(algoType, devGroupType);
                    //case MinerBaseType.mkxminer:
                    //return Data.mkxminer;
            }
            return Data.NONE;
        }

        /// <summary>
        /// The GetPathFor
        /// </summary>
        /// <param name="computeDevice">The <see cref="ComputeDevice"/></param>
        /// <param name="algorithm">The <see cref="Algorithm"/></param>
        /// <returns>The <see cref="string"/></returns>
        public static string GetPathFor(ComputeDevice computeDevice, Algorithm algorithm /*, Options: MinerPathsConfig*/)
        {
            if (computeDevice == null || algorithm == null)
            {
                return Data.NONE;
            }

            return GetPathFor(
                algorithm.MinerBaseType,
                algorithm.CryptoMiner937ID,
                computeDevice.DeviceGroupType
                );
        }

        /// <summary>
        /// The IsValidMinerPath
        /// </summary>
        /// <param name="minerPath">The <see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public static bool IsValidMinerPath(string minerPath)
        {
            // TODO make a list of valid miner paths and check that instead
            return minerPath != null && Data.NONE != minerPath && minerPath != "";
        }

        /**
         * InitAlgorithmsMinerPaths gets and sets miner paths
         */
        /// <summary>
        /// The GetAndInitAlgorithmsMinerPaths
        /// </summary>
        /// <param name="algos">The <see cref="List{Algorithm}"/></param>
        /// <param name="computeDevice">The <see cref="ComputeDevice"/></param>
        /// <returns>The <see cref="List{Algorithm}"/></returns>
        public static List<Algorithm> GetAndInitAlgorithmsMinerPaths(List<Algorithm> algos, ComputeDevice computeDevice/*, Options: MinerPathsConfig*/)
        {
            var retAlgos = algos.FindAll((a) => a != null).ConvertAll((a) =>
            {
                a.MinerBinaryPath = GetPathFor(computeDevice, a/*, Options*/);
                return a;
            });

            return retAlgos;
        }

        // NEW END

        ////// private stuff from here on
        /// <summary>
        /// Defines the <see cref="NVIDIA_GROUPS" />
        /// </summary>
        private static class NVIDIA_GROUPS
        {
            /// <summary>
            /// The Ccminer_sm21_or_sm3x
            /// </summary>
            /// <param name="algorithmType">The <see cref="AlgorithmType"/></param>
            /// <returns>The <see cref="string"/></returns>
            public static string Ccminer_sm21_or_sm3x(AlgorithmType algorithmType)
            {
                if (AlgorithmType.Decred == algorithmType)
                {
                    return Data.ccminer_decred;
                }
                if (AlgorithmType.CryptoNight == algorithmType)
                {
                    return Data.ccminer_cryptonight;
                }
                return Data.ccminer_tpruvot;
            }

            /// <summary>
            /// The Ccminer_sm5x
            /// </summary>
            /// <param name="algorithmType">The <see cref="AlgorithmType"/></param>
            /// <returns>The <see cref="string"/></returns>
            public static string Ccminer_sm5x(AlgorithmType algorithmType)
            {
                if (AlgorithmType.Decred == algorithmType)
                {
                    return Data.ccminer_decred;
                }
                if (AlgorithmType.Lyra2RE == algorithmType)
                {
                    return Data.ccminer_nanashi;
                }
                if (AlgorithmType.CryptoNight == algorithmType)
                {
                    return Data.ccminer_cryptonight;
                }
                if (AlgorithmType.NeoScrypt == algorithmType)
                {
                    return Data.ccminer_tpruvot;
                }
                if (AlgorithmType.Sia == algorithmType)
                {
                    return Data.ccminer_klaust;
                }
                if (AlgorithmType.Xevan == algorithmType)
                {
                    return Data.ccminer_xevan;
                }
                if (AlgorithmType.X17 == algorithmType
                     || AlgorithmType.Blake256r8 == algorithmType
                     || AlgorithmType.X11evo == algorithmType
                     || AlgorithmType.X11Gost == algorithmType)
                {
                    return Data.ccminer_palgin;
                }
                if (AlgorithmType.Hsr == algorithmType)
                {
                    return Data.ccminer_alexis_hsr;
                }
                if (AlgorithmType.Phi == algorithmType
                    || AlgorithmType.NeoScrypt == algorithmType
                    || AlgorithmType.Tribus == algorithmType
                    || AlgorithmType.Skunk == algorithmType)
                {
                    return Data.ccminer_tpruvot2;
                }
                if (AlgorithmType.X17 == algorithmType
                    //zpool removed veltor
                    //|| AlgorithmType.Veltor == algorithmType
                    || AlgorithmType.Lbry == algorithmType
                    || AlgorithmType.Lyra2REv2 == algorithmType
                    || AlgorithmType.Blake2s == algorithmType
                    || AlgorithmType.Nist5 == algorithmType
                    || AlgorithmType.Skein == algorithmType
                    || AlgorithmType.Keccak == algorithmType
                    || AlgorithmType.Polytimos == algorithmType)
                {
                    return Data.ccminer_polytimos;
                }
                if (AlgorithmType.Bitcore == algorithmType)
                {
                    return Data.ccminer_22;
                }
                if (AlgorithmType.Hsr == algorithmType
                    || AlgorithmType.Blake256r8 == algorithmType
                    || AlgorithmType.X11Gost == algorithmType
                    || AlgorithmType.C11 == algorithmType)
                {
                    return Data.ccminer_alexis78;
                }
                if (AlgorithmType.Timetravel == algorithmType)
                {
                    return Data.ccminer_skunkkrnlx;
                }

                return Data.ccminer_sp;
            }

            /// <summary>
            /// The Ccminer_sm6x
            /// </summary>
            /// <param name="algorithmType">The <see cref="AlgorithmType"/></param>
            /// <returns>The <see cref="string"/></returns>
            public static string Ccminer_sm6x(AlgorithmType algorithmType)
            {
                if (AlgorithmType.Decred == algorithmType)
                {
                    return Data.ccminer_decred;
                }
                if (AlgorithmType.Lyra2RE == algorithmType)
                {
                    return Data.ccminer_nanashi;
                }
                if (AlgorithmType.CryptoNight == algorithmType)
                {
                    return Data.ccminer_cryptonight;
                }
                if (AlgorithmType.NeoScrypt == algorithmType)
                {
                    return Data.ccminer_tpruvot;
                }
                if (AlgorithmType.Sia == algorithmType)
                {
                    return Data.ccminer_klaust;
                }
                if (AlgorithmType.Xevan == algorithmType)
                {
                    return Data.ccminer_xevan;
                }
                if (AlgorithmType.X17 == algorithmType
                     || AlgorithmType.Blake256r8 == algorithmType
                     || AlgorithmType.X11evo == algorithmType
                    || AlgorithmType.X11Gost == algorithmType)
                {
                    return Data.ccminer_palgin;
                }
                if (AlgorithmType.Hsr == algorithmType)
                {
                    return Data.ccminer_alexis_hsr;
                }
                if (AlgorithmType.Phi == algorithmType
                    || AlgorithmType.NeoScrypt == algorithmType
                    || AlgorithmType.Tribus == algorithmType
                    || AlgorithmType.Skunk == algorithmType)
                {
                    return Data.ccminer_tpruvot2;
                }
                if (AlgorithmType.X17 == algorithmType
                    //zpool removed veltor
                    //|| AlgorithmType.Veltor == algorithmType
                    || AlgorithmType.Lbry == algorithmType
                    || AlgorithmType.Lyra2REv2 == algorithmType
                    || AlgorithmType.Blake2s == algorithmType
                    || AlgorithmType.Nist5 == algorithmType
                    || AlgorithmType.Skein == algorithmType
                    || AlgorithmType.Keccak == algorithmType
                    || AlgorithmType.Polytimos == algorithmType)
                {
                    return Data.ccminer_polytimos;
                }
                if (AlgorithmType.Bitcore == algorithmType)
                {
                    return Data.ccminer_22;
                }
                if (AlgorithmType.Hsr == algorithmType
                    || AlgorithmType.Blake256r8 == algorithmType
                    || AlgorithmType.X11Gost == algorithmType
                    || AlgorithmType.C11 == algorithmType)
                {
                    return Data.ccminer_alexis78;
                }
                if (AlgorithmType.Timetravel == algorithmType)
                {
                    return Data.ccminer_skunkkrnlx;
                }

                return Data.ccminer_sp;
            }

            /// <summary>
            /// The Palgin_Neoscrypt_path
            /// </summary>
            /// <param name="algorithmType">The <see cref="AlgorithmType"/></param>
            /// <param name="nvidiaGroup">The <see cref="DeviceGroupType"/></param>
            /// <returns>The <see cref="string"/></returns>
            public static string Palgin_Neoscrypt_path(AlgorithmType algorithmType, DeviceGroupType nvidiaGroup)
            {
                // sm21 and sm3x have same settings                
                // CN exception
                if (nvidiaGroup == DeviceGroupType.NVIDIA_2_1 || nvidiaGroup == DeviceGroupType.NVIDIA_3_x)
                {
                    return Data.NONE;
                }
                if (nvidiaGroup == DeviceGroupType.NVIDIA_5_x)
                {
                    return Data.NONE;
                }
                if (nvidiaGroup == DeviceGroupType.NVIDIA_6_x)
                {
                    return Data.Palgin_Neoscrypt;
                }

                // TODO wrong case?
                return Data.NONE; // should not happen
            }

            /// <summary>
            /// The Palgin_HSR_path
            /// </summary>
            /// <param name="algorithmType">The <see cref="AlgorithmType"/></param>
            /// <param name="nvidiaGroup">The <see cref="DeviceGroupType"/></param>
            /// <returns>The <see cref="string"/></returns>
            public static string Palgin_HSR_path(AlgorithmType algorithmType, DeviceGroupType nvidiaGroup)
            {
                // sm21 and sm3x have same settings                
                // CN exception
                if (nvidiaGroup == DeviceGroupType.NVIDIA_2_1 || nvidiaGroup == DeviceGroupType.NVIDIA_3_x)
                {
                    return Data.NONE;
                }
                if (nvidiaGroup == DeviceGroupType.NVIDIA_5_x)
                {
                    return Data.NONE;
                }
                if (nvidiaGroup == DeviceGroupType.NVIDIA_6_x)
                {
                    return Data.Palgin_HSR;
                }

                // TODO wrong case?
                return Data.NONE; // should not happen
            }

            /// <summary>
            /// The Ccminer_path
            /// </summary>
            /// <param name="algorithmType">The <see cref="AlgorithmType"/></param>
            /// <param name="nvidiaGroup">The <see cref="DeviceGroupType"/></param>
            /// <returns>The <see cref="string"/></returns>
            public static string Ccminer_path(AlgorithmType algorithmType, DeviceGroupType nvidiaGroup)
            {
                // sm21 and sm3x have same settings
                if (nvidiaGroup == DeviceGroupType.NVIDIA_2_1 || nvidiaGroup == DeviceGroupType.NVIDIA_3_x)
                {
                    return NVIDIA_GROUPS.Ccminer_sm21_or_sm3x(algorithmType);
                }
                // CN exception
                if (nvidiaGroup == DeviceGroupType.NVIDIA_6_x && algorithmType == AlgorithmType.CryptoNight || AlgorithmType.Tribus == algorithmType)
                {
                    return Data.ccminer_tpruvot;
                }
                // sm5x and sm6x have same settings otherwise
                if (nvidiaGroup == DeviceGroupType.NVIDIA_5_x)
                {
                    return NVIDIA_GROUPS.Ccminer_sm5x(algorithmType);
                }
                if (nvidiaGroup == DeviceGroupType.NVIDIA_6_x)
                {
                    return NVIDIA_GROUPS.Ccminer_sm6x(algorithmType);
                }
                // TODO wrong case?
                return Data.NONE; // should not happen
            }

            // untested might not need anymore
            /// <summary>
            /// The Ccminer_unstable_path
            /// </summary>
            /// <param name="algorithmType">The <see cref="AlgorithmType"/></param>
            /// <param name="nvidiaGroup">The <see cref="DeviceGroupType"/></param>
            /// <returns>The <see cref="string"/></returns>
            public static string Ccminer_unstable_path(AlgorithmType algorithmType, DeviceGroupType nvidiaGroup)
            {
                // sm5x and sm6x have same settings
                if (nvidiaGroup == DeviceGroupType.NVIDIA_5_x || nvidiaGroup == DeviceGroupType.NVIDIA_6_x)
                {

                    if (AlgorithmType.X11Gost == algorithmType || AlgorithmType.Nist5 == algorithmType || AlgorithmType.X17 == algorithmType || AlgorithmType.Nist5 == algorithmType)

                    {
                        return Data.ccminer_x11gost;
                    }
                }
                // TODO wrong case?
                return Data.NONE; // should not happen
            }
        }

        /// <summary>
        /// Defines the <see cref="AMD_GROUP" />
        /// </summary>
        private static class AMD_GROUP
        {
            /// <summary>
            /// The Sgminer_path
            /// </summary>
            /// <param name="type">The <see cref="AlgorithmType"/></param>
            /// <returns>The <see cref="string"/></returns>
            public static string Sgminer_path(AlgorithmType type)
            {
                if (AlgorithmType.CryptoNight == type || AlgorithmType.DaggerHashimoto == type)
                {
                    return Data.sgminer_gm;
                }
                if (AlgorithmType.Skein == type)
                {
                    return Data.sgminer_Skein;
                }
                if (AlgorithmType.Bitcore == type)
                {
                    return Data.sgminer_Bitcore;
                }
                if (AlgorithmType.Hsr == type)
                {
                    return Data.sgminer_HSR;
                }
                if (AlgorithmType.Phi == type)
                {
                    return Data.sgminer_Phi;
                }
                if (AlgorithmType.Tribus == type)
                {
                    return Data.sgminer_Tribus;
                }
                if (AlgorithmType.Xevan == type)
                {
                    return Data.sgminer_Xevan;
                }

                return Data.sgminer_5_6_0_general;
            }

            /// <summary>
            /// The Glg_path
            /// </summary>
            /// <param name="type">The <see cref="AlgorithmType"/></param>
            /// <returns>The <see cref="string"/></returns>
            public static string Glg_path(AlgorithmType type)
            {
                // AlgorithmType.Pascal == type || AlgorithmType.DaggerHashimoto == type || AlgorithmType.Decred == type || AlgorithmType.Lbry == type || AlgorithmType.X11Gost == type || AlgorithmType.DaggerHashimoto == type
                if (AlgorithmType.CryptoNight == type || AlgorithmType.Equihash == type || AlgorithmType.NeoScrypt == type || AlgorithmType.Lyra2REv2 == type || AlgorithmType.Myriad_groestl == type || AlgorithmType.Keccak == type)
                {
                    return Data.glg;
                }
                return Data.NONE;
            }

            /// <summary>
            /// The ClaymorePath
            /// </summary>
            /// <param name="type">The <see cref="AlgorithmType"/></param>
            /// <returns>The <see cref="string"/></returns>
            public static string ClaymorePath(AlgorithmType type)
            {
                if (AlgorithmType.Equihash == type)
                {
                    return Data.ClaymoreZcashMiner;
                }
                else if (AlgorithmType.CryptoNight == type)
                {
                    return Data.ClaymoreCryptoNightMiner;
                }
                else if (AlgorithmType.DaggerHashimoto == type)
                {
                    return Data.ClaymoreDual;
                }
                return Data.NONE; // should not happen
            }
        }

        /// <summary>
        /// Defines the <see cref="CPU_GROUP" />
        /// </summary>
        internal static class CPU_GROUP
        {
            /// <summary>
            /// The cpu_miner_opt
            /// </summary>
            /// <param name="type">The <see cref="CPUExtensionType"/></param>
            /// <returns>The <see cref="string"/></returns>
            public static string cpu_miner_opt(CPUExtensionType type)
            {
                // algorithmType is not needed ATM
                // algorithmType: AlgorithmType
                if (CPUExtensionType.AVX2_AES == type) { return Data.cpuminer_opt_AVX2_AES; }
                if (CPUExtensionType.AVX2 == type) { return Data.cpuminer_opt_AVX2; }
                if (CPUExtensionType.AVX_AES == type) { return Data.cpuminer_opt_AVX_AES; }
                if (CPUExtensionType.AVX == type) { return Data.cpuminer_opt_AVX; }
                if (CPUExtensionType.AES == type) { return Data.cpuminer_opt_AES; }
                if (CPUExtensionType.SSE2 == type) { return Data.cpuminer_opt_SSE2; }

                return Data.NONE; // should not happen
            }
        }

        // unstable miners, NVIDIA for now
        /// <summary>
        /// Defines the <see cref="EXPERIMENTAL" />
        /// </summary>
        private static class EXPERIMENTAL
        {
            /// <summary>
            /// The GetPath
            /// </summary>
            /// <param name="algoType">The <see cref="AlgorithmType"/></param>
            /// <param name="devGroupType">The <see cref="DeviceGroupType"/></param>
            /// <returns>The <see cref="string"/></returns>
            public static string GetPath(AlgorithmType algoType, DeviceGroupType devGroupType)
            {
                if (devGroupType == DeviceGroupType.NVIDIA_6_x)
                {
                    return NVIDIA_GROUPS.Ccminer_path(algoType, devGroupType);
                }
                return Data.NONE; // should not happen
            }
        }

        /// <summary>
        /// Defines the minerPathPackages
        /// </summary>
        private static List<MinerPathPackage> minerPathPackages = new List<MinerPathPackage>();

        /// <summary>
        /// Defines the configurableMiners
        /// </summary>
        private static readonly List<MinerBaseType> configurableMiners = new List<MinerBaseType> {
            MinerBaseType.ccminer,
            MinerBaseType.sgminer
        };

        /// <summary>
        /// The InitializePackages
        /// </summary>
        public static void InitializePackages()
        {
            var defaults = new List<MinerPathPackage>();
            for (var i = DeviceGroupType.NONE + 1; i < DeviceGroupType.LAST; i++)
            {
                var minerTypePaths = new List<MinerTypePath>();
                var package = GroupAlgorithms.CreateDefaultsForGroup(i);
                foreach (var type in configurableMiners)
                {
                    if (package.ContainsKey(type))
                    {
                        var minerPaths = new List<MinerPath>();
                        foreach (var algo in package[type])
                        {
                            minerPaths.Add(new MinerPath(algo.CryptoMiner937ID, GetPathFor(type, algo.CryptoMiner937ID, i, true)));
                        }
                        minerTypePaths.Add(new MinerTypePath(type, minerPaths));
                    }
                }
                if (minerTypePaths.Count > 0)
                {
                    defaults.Add(new MinerPathPackage(i, minerTypePaths));
                }
            }

            foreach (var pack in defaults)
            {
                var packageName = String.Format("MinerPathPackage_{0}", pack.Name);
                var packageFile = new MinerPathPackageFile(packageName);
                var readPack = packageFile.ReadFile();
                if (readPack == null)
                {   // read has failed
                    Helpers.ConsolePrint("MinerPaths", "Creating internal paths config " + packageName);
                    minerPathPackages.Add(pack);
                    packageFile.Commit(pack);
                }
                else
                {
                    Helpers.ConsolePrint("MinerPaths", "Loading internal paths config " + packageName);
                    var isChange = false;
                    foreach (var miner in pack.MinerTypes)
                    {
                        var readMiner = readPack.MinerTypes.Find(x => x.Type == miner.Type);
                        if (readMiner != null)
                        {  // file contains miner type
                            foreach (var algo in miner.Algorithms)
                            {
                                if (!readMiner.Algorithms.Exists(x => x.Algorithm == algo.Algorithm))
                                {  // file does not contain algo on this miner
                                    Helpers.ConsolePrint("PATHS", String.Format("Algorithm {0} not found in miner {1} on device {2}. Adding default", algo.Name, miner.Name, pack.Name));
                                    readMiner.Algorithms.Add(algo);
                                    isChange = true;
                                }
                            }
                        }
                        else
                        {  // file does not contain miner type
                            Helpers.ConsolePrint("PATHS", String.Format("Miner {0} not found on device {1}", miner.Name, pack.Name));
                            readPack.MinerTypes.Add(miner);
                            isChange = true;
                        }
                    }
                    minerPathPackages.Add(readPack);
                    if (isChange) packageFile.Commit(readPack);
                }
            }
        }
    }
}
