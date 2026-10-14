using ConversionAPI.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionAPI.Application.Interfaces
{
    public interface IUnitConversionService
    {
        UnitConversionResponse Convert(UnitConversionRequest request);
    }
}
