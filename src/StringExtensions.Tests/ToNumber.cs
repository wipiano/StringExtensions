using System;
using Xunit;

namespace StringExtensions.Tests
{
    public class ToNumber
    {
        [Fact]
        public void ToNumberTest()
        {
            "-123".ToSignedByte().Is((sbyte)-123);
            "234".ToByte().Is((byte)234);
            "-23456".ToShort().Is((short)-23456);
            "65432".ToUnsignedShort().Is((ushort)65432);
            "-123456".ToInt().Is(-123456);
            "123456".ToUnsignedInt().Is(123456u);
            "-123456".ToLong().Is(-123456L);
            "123456".ToUnsignedLong().Is(123456uL);
            
            // failed to parse
            Assert.Throws<ArgumentNullException>(() => (null as string).ToInt());
            Assert.Throws<FormatException>(() => "hoge".ToInt());
            Assert.Throws<OverflowException>(() => "12345".ToByte());
        }
    }
}