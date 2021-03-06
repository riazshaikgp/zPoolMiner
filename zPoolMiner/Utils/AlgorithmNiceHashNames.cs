﻿namespace zPoolMiner
{
    using System;
    using zPoolMiner.Enums;

    /// <summary>
    /// AlgorithmCryptoMiner937Names class is just a data container for mapping NiceHash JSON API names to algo type
    /// </summary>
    public static class AlgorithmCryptoMiner937Names
    {
        /// <summary>
        /// The GetName
        /// </summary>
        /// <param name="type">The <see cref="AlgorithmType"/></param>
        /// <returns>The <see cref="string"/></returns>
        public static string GetName(AlgorithmType type)
        {
            if ((AlgorithmType.INVALID <= type && type <= AlgorithmType.Skunk)
                || (AlgorithmType.DaggerSia <= type && type <= AlgorithmType.DaggerPascal)
                || (AlgorithmType.X17 <= type && type <= AlgorithmType.X17)
                || (AlgorithmType.Tribus <= type && type <= AlgorithmType.Tribus)
                || (AlgorithmType.Timetravel <= type && type <= AlgorithmType.Timetravel)
                || (AlgorithmType.Veltor <= type && type <= AlgorithmType.Veltor)
                || (AlgorithmType.Xevan <= type && type <= AlgorithmType.Xevan)
                || (AlgorithmType.INVALID <= type && type <= AlgorithmType.Yescrypt)
                || (AlgorithmType.INVALID <= type && type <= AlgorithmType.Xevan)

                )
            {
                return Enum.GetName(typeof(AlgorithmType), type);
            }
            return "NameNotFound type not supported";
        }
    }
}
