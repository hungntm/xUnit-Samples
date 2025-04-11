using Xunit;

namespace MyFirstUnitTests
{
    public class HelloWorldUnitTest
    {
        [Fact]
        public void HelloTest()
        {
            Assert.Equal("Hello World", SayHello("World"));
        }

        #region "Sample application code"
        string SayHello(string name)
        {
            return $"Hello {name}";
        }
        #endregion
    }
}
