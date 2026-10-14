using ConversionAPI.Application.DTOs;
using ConversionAPI.Application.Interfaces;

namespace ConversionAPI.Application.Services
{
    public class UnitConversionService : IUnitConversionService
    {
        private readonly IEnumerable<IUnitConversionProvider> _providers;

        public UnitConversionService(
            IEnumerable<IUnitConversionProvider> providers)
        {
            _providers = providers;
        }

        public UnitConversionResponse Convert(
            UnitConversionRequest request)
        {
            ArgumentNullException.ThrowIfNull(request);

            if (string.IsNullOrWhiteSpace(request.FromUnit) ||
                string.IsNullOrWhiteSpace(request.ToUnit))
            {
                throw new ArgumentException(
                    "FromUnit and ToUnit are required.");
            }

            var fromUnit = request.FromUnit.Trim();
            var toUnit = request.ToUnit.Trim();

            var provider = _providers.FirstOrDefault(
                p => p.Supports(fromUnit, toUnit));

            if (provider is null)
            {
                throw new ArgumentException(
                    $"Conversion from '{fromUnit}' to '{toUnit}' " +
                    "is not supported.");
            }

            var result = provider.Convert(
                request.Value,
                fromUnit,
                toUnit);

            return new UnitConversionResponse
            {
                OriginalValue = request.Value,
                FromUnit = fromUnit,
                ConvertedValue = decimal.Round(
                    result, 6, MidpointRounding.AwayFromZero),
                ToUnit = toUnit
            };
        }
    }
}
