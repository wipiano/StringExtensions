namespace StringExtensions
{
    public static partial class StringEx
    {
        /// <summary>
        /// Indicates whether the specified string is null or an Empty string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string s)
            => string.IsNullOrEmpty(s);

        /// <summary>
        /// Indicates whether a specified string is null, empty, or consists only of white-space characters.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsNullOrWhiteSpace(this string s)
            => string.IsNullOrWhiteSpace(s);

        /// <summary>
        /// Indicates whether the specified string is null
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsNull(this string s)
            => s == null;

        /// <summary>
        /// Indicates whether the specified string is an Empty string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsEmpty(this string s)
            => s == string.Empty;
    }
}