using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Refge.Tests
{
    [TestClass]
    public class RefgeTests
    {
        [TestMethod]
        public void GetVersionShouldSucceed()
        {
            var result = Refge.GetVersion("1.0");
            result.Should().Be("v1.0");
        }

        [TestMethod]
        public void GetAVersionShouldSucceed()
        {
            var result = Refge.GetAVersion("1.0");
            result.Should().Be("a1.0");
        }
    }
}
