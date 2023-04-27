// add a namespace for the WeatherForecastController
using  WebApi.Controllers;

namespace WebApiTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void GetWeatherForecastByLengthTest()
    {
        // Arrange
        var controller = new WeatherForecastController(null);

        // Act
        var result = controller.GetRange(new DateRange { Length = 5 });

        // Assert
        Assert.AreEqual(5, result.Count());
    }
}