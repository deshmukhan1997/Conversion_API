using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionAPI.Application.Interfaces
{
    public interface IUnitConversionProvider
    {
        bool Supports(string fromUnit, string toUnit);

        decimal Convert(
            decimal value,
            string fromUnit,
            string toUnit);
    }
}
