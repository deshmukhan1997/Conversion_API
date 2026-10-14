using ConversionAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionAPI.Infrastructure.Providers
{
    public class WeightConversionProvider : IUnitConversionProvider
    {
        private const decimal KilogramsPerPound = 0.45359237m;

        private static readonly HashSet<string> KilogramUnits =
            new(StringComparer.OrdinalIgnoreCase)
            {
            "kg", "kilogram", "kilograms"
            };

        private static readonly HashSet<string> PoundUnits =
            new(StringComparer.OrdinalIgnoreCase)
            {
            "lb", "lbs", "pound", "pounds"
            };

        public bool Supports(string fromUnit, string toUnit)
        {
            bool validFrom = KilogramUnits.Contains(fromUnit) ||
                             PoundUnits.Contains(fromUnit);

            bool validTo = KilogramUnits.Contains(toUnit) ||
                           PoundUnits.Contains(toUnit);

            return validFrom && validTo;
        }

        public decimal Convert(
            decimal value,
            string fromUnit,
            string toUnit)
        {
            bool fromKg = KilogramUnits.Contains(fromUnit);
            bool toKg = KilogramUnits.Contains(toUnit);

            if (fromKg && toKg)
                return value;

            if (fromKg)
                return value / KilogramsPerPound;

            if (toKg)
                return value * KilogramsPerPound;

            return value;
        }
    }
}
