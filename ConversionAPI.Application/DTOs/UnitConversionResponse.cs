using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionAPI.Application.DTOs
{
    public class UnitConversionResponse
    {
        public decimal OriginalValue { get; set; }

        public string FromUnit { get; set; } = string.Empty;

        public decimal ConvertedValue { get; set; }

        public string ToUnit { get; set; } = string.Empty;
    }
}
