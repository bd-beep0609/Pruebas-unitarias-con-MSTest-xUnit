namespace BADC.Temperatura
{
    public class TemperatureConverter
    {
        public double CelsiusToFahrenheit(double celsius)
        {
            // Fórmula: (C * 9/5) + 32
            return (celsius * 9 / 5) + 32;
        }

        public double FahrenheitToCelsius(double fahrenheit)
        {
            // Fórmula: (F - 32) * 5/9
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}