using Microsoft.VisualStudio.TestTools.UnitTesting;
using BADC.Temperatura;

namespace BADC.Temperatura.UnitTestMSTest
{
    [TestClass]
    public class TemperatureConverterTests
    {
        [TestMethod]
        public void CelsiusToFahrenheit_ShouldReturnCorrectValue()
        {
            // Arrange
            var converter = new TemperatureConverter();
            double celsius = 25.0;

            // Act
            double result = converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(77.0, result, 0.001, "La conversión de Celsius a Fahrenheit es incorrecta.");
        }

        [TestMethod]
        public void FahrenheitToCelsius_ShouldReturnCorrectValue()
        {
            // Arrange
            var converter = new TemperatureConverter();
            double fahrenheit = 77.0;

            // Act
            double result = converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(25.0, result, 0.001, "La conversión de Fahrenheit a Celsius es incorrecta.");
        }
    }
}