using System;
using SimpleAPI.Controllers;
using Xunit;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();
        [Fact]
        public void GetReturnsCorrectNumber()
        {
            var returnValue = controller.Get(23);
            Assert.Equal("Les Jackson", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
