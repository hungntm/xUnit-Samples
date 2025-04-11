using Microsoft.Extensions.Logging;
using Moq;
using SampleMvcApp.Controllers;
using SampleMvcApp.Core;
using Xunit;

namespace SampleMvcApp.Test
{
    public class MockingUnitTest
    {
        [Fact]
        public void MockingTestController()
        {
            var mock = new Mock<ILogger<TestController>>();
            var logger = mock.Object;
            TestController test = new TestController(logger);
            string result = test.GetMessage();

            Assert.Equal("Hi! Rookies", result);
        }

        [Fact]
        public void MockingHomeController()
        {
            // Arrange
            var mock = new Mock<IGetDataRepository>();
            //mock.Setup(p => p.GetNameById(1)).Returns("Rookies");
            mock.Setup(p => p.GetNameById(2)).Returns("Rookies2");
            HomeController home = new HomeController(mock.Object);
            // Act
            string result = home.GetNameById(2);
            // Assert
            Assert.Equal("Rookies", result);
        }
    }
}
