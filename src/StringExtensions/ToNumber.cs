namespace StringExtensions
{
    public static partial class StringEx
    {
        /// <summary>
        /// parse string as sbyte
        /// </summary>
        public static sbyte ToSignedByte(this string s)
            => sbyte.Parse(s);

        /// <summary>
        /// parse string as byte
        /// </summary>
        public static byte ToByte(this string s)
            => byte.Parse(s);

        /// <summary>
        /// parse string as short
        /// </summary>
        public static short ToShort(this string s)
            => short.Parse(s);

        /// <summary>
        /// parse string as ushort
        /// </summary>
        public static ushort ToUnsignedShort(this string s)
            => ushort.Parse(s);

        /// <summary>
        /// parse string as int
        /// </summary>
        public static int ToInt(this string s)
            => int.Parse(s);

        /// <summary>
        /// parse string as uint
        /// </summary>
        public static uint ToUnsignedInt(this string s)
            => uint.Parse(s);

        /// <summary>
        /// parse string as long
        /// </summary>
        public static long ToLong(this string s)
            => long.Parse(s);

        /// <summary>
        /// parse string as ulong
        /// </summary>
        public static ulong ToUnsignedLong(this string s)
            => ulong.Parse(s);

        /// <summary>
        /// parse string as float
        /// </summary>
        public static float ToFloat(this string s)
            => float.Parse(s);

        /// <summary>
        /// parse string as double
        /// </summary>
        public static double ToDouble(this string s)
            => double.Parse(s);

        /// <summary>
        /// parse string as decimal
        /// </summary>
        public static decimal ToDecimal(this string s)
            => decimal.Parse(s);
    }
}