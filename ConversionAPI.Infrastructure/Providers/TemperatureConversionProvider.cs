using ConversionAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionAPI.Infrastructure.Providers
{
    public class TemperatureConversionProvider
    : IUnitConversionProvider
    {
        private static readonly HashSet<string> CelsiusUnits =
            new(StringComparer.OrdinalIgnoreCase)
            {
            "c", "celsius"
            };

        private static readonly HashSet<string> FahrenheitUnits =
            new(StringComparer.OrdinalIgnoreCase)
            {
            "f", "fahrenheit"
            };

        public bool Supports(string fromUnit, string toUnit)
        {
            bool validFrom = CelsiusUnits.Contains(fromUnit) ||
                             FahrenheitUnits.Contains(fromUnit);

            bool validTo = CelsiusUnits.Contains(toUnit) ||
                           FahrenheitUnits.Contains(toUnit);

            return validFrom && validTo;
        }

        public decimal Convert(
            decimal value,
            string fromUnit,
            string toUnit)
        {
            bool fromCelsius = CelsiusUnits.Contains(fromUnit);
            bool toCelsius = CelsiusUnits.Contains(toUnit);

            if (fromCelsius && toCelsius)
                return value;

            if (fromCelsius)
                return (value * 9m / 5m) + 32m;

            if (toCelsius)
                return (value - 32m) * 5m / 9m;

            return value;
        }
    }
}
