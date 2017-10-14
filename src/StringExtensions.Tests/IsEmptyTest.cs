using Xunit;

namespace StringExtensions.Tests
{
    public class IsEmptyTest
    {
        [Xunit.Fact]
        public void IsEmptyTests()
        {
            (null as string).IsNull().IsTrue();
            "".IsNull().IsFalse();
            "hoge".IsNull().IsFalse();
            " ".IsNull().IsFalse();
            
            (null as string).IsEmpty().IsFalse();
            "".IsEmpty().IsTrue();
            "hoge".IsEmpty().IsFalse();
            " ".IsEmpty().IsFalse();
            
            (null as string).IsNullOrEmpty().IsTrue();
            "".IsNullOrEmpty().IsTrue();
            "hoge".IsNullOrEmpty().IsFalse();
            " ".IsNullOrEmpty().IsFalse();

            (null as string).IsNullOrWhiteSpace().IsTrue();
            "".IsNullOrWhiteSpace().IsTrue();
            "hoge".IsNullOrWhiteSpace().IsFalse();
            " ".IsNullOrWhiteSpace().IsTrue();
        }
    }
}