using ConversionAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionAPI.Infrastructure.Providers
{
    public class LengthConversionProvider : IUnitConversionProvider
    {
        private static readonly Dictionary<string, decimal> MetersPerUnit =
            new(StringComparer.OrdinalIgnoreCase)
            {
                ["m"] = 1m,
                ["meter"] = 1m,
                ["meters"] = 1m,
                ["ft"] = 0.3048m,
                ["foot"] = 0.3048m,
                ["feet"] = 0.3048m,
                ["km"] = 1000m,
                ["kilometer"] = 1000m,
                ["kilometers"] = 1000m,
                ["mi"] = 1609.344m,
                ["mile"] = 1609.344m,
                ["miles"] = 1609.344m
            };

        public bool Supports(string fromUnit, string toUnit)
        {
            return MetersPerUnit.ContainsKey(fromUnit) &&
                   MetersPerUnit.ContainsKey(toUnit);
        }

        public decimal Convert(
            decimal value,
            string fromUnit,
            string toUnit)
        {
            decimal meters = value * MetersPerUnit[fromUnit];

            return meters / MetersPerUnit[toUnit];
        }
    }
}
