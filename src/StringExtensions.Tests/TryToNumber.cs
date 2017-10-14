using Xunit;

namespace StringExtensions.Tests
{
    public class TryToNumber
    {
        [Fact]
        public void TryToNumberTest()
        {
            {
                "-123".ToSignedByte(out var result).IsTrue();
                result.Is((sbyte)-123);
            }

            {
                "234".ToByte(out var result).IsTrue();
                result.Is((byte)234);
            }

            {
                "-23456".ToShort(out var result).IsTrue();
                result.Is((short)-23456);
            }

            {
                "65432".ToUnsignedShort(out var result).IsTrue();
                result.Is((ushort)65432);
            }

            {
                "-123456".ToInt(out var result).IsTrue();
                result.Is(-123456);
            }

            {
                "123456".ToUnsignedInt(out var result).IsTrue();
                result.Is(123456u);
            }

            {
                "-123456".ToLong(out var result).IsTrue();
                result.Is(-123456L);
            }

            {
                "123456".ToUnsignedLong(out var result).IsTrue();
                result.Is(123456uL);
            }

            {
                "123.456".ToFloat(out var result).IsTrue();
                result.Is(123.456f);
            }

            {
                "123.4567890".ToDouble(out var result).IsTrue();
                result.Is(123.4567890);
            }

            {
                "1948385.48484848".ToDecimal(out var result).IsTrue();
                result.Is(1948385.48484848m);
            }

            // failed to parse
            {
                (null as string).ToInt(out var result).IsFalse();
            }

            {
                "hoge".ToInt(out var result).IsFalse();
            }

            {
                "1234567890".ToByte(out var result).IsFalse();
            }
        }
    }
}