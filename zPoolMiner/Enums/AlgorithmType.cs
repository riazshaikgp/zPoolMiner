namespace zPoolMiner.Enums
{
    /// <summary>
    /// AlgorithmType enum should/must mirror the values from https://www.nicehash.com/?p=api
    /// Some algorithms are not used anymore on the client, rename them with _UNUSED postfix so we can catch compile time errors if they are used.
    /// </summary>
    public enum AlgorithmType : int
    {
        // dual algos for grouping

        /// <summary>
        /// Defines the DaggerSia
        /// </summary>
        DaggerSia = -6,

        /// <summary>
        /// Defines the DaggerDecred
        /// </summary>
        DaggerDecred = -5,

        /// <summary>
        /// Defines the DaggerLbry
        /// </summary>
        DaggerLbry = -4,

        /// <summary>
        /// Defines the DaggerPascal
        /// </summary>
        DaggerPascal = -3,

        /// <summary>
        /// Defines the INVALID
        /// </summary>
        INVALID = -2,

        /// <summary>
        /// Defines the NONE
        /// </summary>
        NONE = -1,

        /// <summary>
        /// Defines the Hodl
        /// </summary>
        Hodl = -14,

        /// <summary>
        /// Defines the Decred
        /// </summary>
        Decred = -13,

        /// <summary>
        /// Defines the CryptoNight
        /// </summary>
        CryptoNight = -12,

        /// <summary>
        /// Defines the Pascal
        /// </summary>
        Pascal = -11,

        /// <summary>
        /// Defines the Sia
        /// </summary>
        Sia = -10,

        /// <summary>
        /// Defines the Blake256r14_UNUSED
        /// </summary>
        Blake256r14_UNUSED = -9,

        /// <summary>
        /// Defines the Blake256r8vnl_UNUSED
        /// </summary>
        Blake256r8vnl_UNUSED = -8,

        /// <summary>
        /// Defines the ScryptNf_UNUSED
        /// </summary>
        ScryptNf_UNUSED = -7,

        /// <summary>
        /// Defines the WhirlpoolX_UNUSED
        /// </summary>
        WhirlpoolX_UNUSED = -6,

        /// <summary>
        /// Defines the Axiom_UNUSED
        /// </summary>
        Axiom_UNUSED = -5,

        /// <summary>
        /// Defines the ScryptJaneNf16_UNUSED
        /// </summary>
        ScryptJaneNf16_UNUSED = -4,

        /// <summary>
        /// Defines the Lyra2RE
        /// </summary>
        Lyra2RE = -3,

        /// <summary>
        /// Defines the X15_UNUSED
        /// </summary>
        X15_UNUSED = -2,

        /// <summary>
        /// Defines the DaggerHashimoto
        /// </summary>
        DaggerHashimoto = -1,

        /// <summary>
        /// Defines the Bitcore
        /// </summary>
        Bitcore = 0,

        /// <summary>
        /// Defines the Blake2s
        /// </summary>
        Blake2s = 1,

        /// <summary>
        /// Defines the Blake256r8
        /// </summary>
        Blake256r8 = 2,

        /// <summary>
        /// Defines the C11
        /// </summary>
        C11 = 3,

        /// <summary>
        /// Defines the Equihash
        /// </summary>
        Equihash = 4,

        /// <summary>
        /// Defines the Groestl
        /// </summary>
        Groestl = 5,

        /// <summary>
        /// Defines the Hsr
        /// </summary>
        Hsr = 6,

        /// <summary>
        /// Defines the Keccak
        /// </summary>
        Keccak = 7,

        /// <summary>
        /// Defines the Lbry
        /// </summary>
        Lbry = 8,

        /// <summary>
        /// Defines the Lyra2REv2
        /// </summary>
        Lyra2REv2 = 9,

        /// <summary>
        /// Defines the Myriad_groestl
        /// </summary>
        Myriad_groestl = 10,

        /// <summary>
        /// Defines the NeoScrypt
        /// </summary>
        NeoScrypt = 11,

        /// <summary>
        /// Defines the Nist5
        /// </summary>
        Nist5 = 12,

        /// <summary>
        /// Defines the Phi
        /// </summary>
        Phi = 13,

        /// <summary>
        /// Defines the Polytimos
        /// </summary>
        Polytimos = 14,

        /// <summary>
        /// Defines the Quark_UNUSED
        /// </summary>
        Quark_UNUSED = 15,

        /// <summary>
        /// Defines the Qubit_UNUSED
        /// </summary>
        Qubit_UNUSED = 16,

        /// <summary>
        /// Defines the Scrypt_UNUSED
        /// </summary>
        Scrypt_UNUSED = 17,

        /// <summary>
        /// Defines the SHA256_UNUSED
        /// </summary>
        SHA256_UNUSED = 18,

        /// <summary>
        /// Defines the X11Gost
        /// </summary>
        X11Gost = 19,

        /// <summary>
        /// Defines the Skein
        /// </summary>
        Skein = 20,

        /// <summary>
        /// Defines the Skunk
        /// </summary>
        Skunk = 21,

        /// <summary>
        /// Defines the Timetravel
        /// </summary>
        Timetravel = 22,

        /// <summary>
        /// Defines the Tribus
        /// </summary>
        Tribus = 23,

        /// <summary>
        /// Defines the Veltor
        /// </summary>
        Veltor = 24,

        /// <summary>
        /// Defines the X11_UNUSED
        /// </summary>
        X11_UNUSED = 25,

        /// <summary>
        /// Defines the X11evo
        /// </summary>
        X11evo = 26,

        /// <summary>
        /// Defines the X13_UNUSED
        /// </summary>
        X13_UNUSED = 27,

        /// <summary>
        /// Defines the X14
        /// </summary>
        X14 = 28,

        /// <summary>
        /// Defines the X17
        /// </summary>
        X17 = 29,

        /// <summary>
        /// Defines the Xevan
        /// </summary>
        Xevan = 30,

        /// <summary>
        /// Defines the Yescrypt
        /// </summary>
        Yescrypt = 31
    }
}
