namespace StringExtensions
{
    public static partial class StringEx
    {
        /// <summary>
        /// try parse string as sbyte
        /// </summary>
        public static bool ToSignedByte(this string s, out sbyte result)
            => sbyte.TryParse(s, out result);

        /// <summary>
        /// try parse string as byte
        /// </summary>
        public static bool ToByte(this string s, out byte result)
            => byte.TryParse(s, out result);

        /// <summary>
        /// try parse string as short
        /// </summary>
        public static bool ToShort(this string s, out short result)
            => short.TryParse(s, out result);

        /// <summary>
        /// try parse string as ushort
        /// </summary>
        public static bool ToUnsignedShort(this string s, out ushort result)
            => ushort.TryParse(s, out result);

        /// <summary>
        /// try parse string as int
        /// </summary>
        public static bool ToInt(this string s, out int result)
            => int.TryParse(s, out result);

        /// <summary>
        /// try parse string as uint
        /// </summary>
        public static bool ToUnsignedInt(this string s, out uint result)
            => uint.TryParse(s, out result);

        /// <summary>
        /// try parse string as long
        /// </summary>
        public static bool ToLong(this string s, out long result)
            => long.TryParse(s, out result);

        /// <summary>
        /// try parse string as ulong
        /// </summary>
        public static bool ToUnsignedLong(this string s, out ulong result)
            => ulong.TryParse(s, out result);

        /// <summary>
        /// try parse string as float
        /// </summary>
        public static bool ToFloat(this string s, out float result)
            => float.TryParse(s, out result);

        /// <summary>
        /// try parse string as double
        /// </summary>
        public static bool ToDouble(this string s, out double result)
            => double.TryParse(s, out result);

        /// <summary>
        /// try parse string as decimal
        /// </summary>
        public static bool ToDecimal(this string s, out decimal result)
            => decimal.TryParse(s, out result);
    }
}