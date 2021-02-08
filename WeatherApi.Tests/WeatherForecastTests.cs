using System;
using Xunit;

namespace WeatherApi.Tests
{
    public class WeatherForecastTests
    {
        [Fact]
        public void Given_TempC_WeatherForecast_ConvertsTo_TempF()
        {
            var sut = new WeatherForecast { TemperatureC = 30 };
            Assert.Equal(expected: 85, actual: sut.TemperatureF);
        }
    }
}
