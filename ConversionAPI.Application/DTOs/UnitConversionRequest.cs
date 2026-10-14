using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionAPI.Application.DTOs
{
    public class UnitConversionRequest
    {
        public decimal Value { get; set; }

        public string FromUnit { get; set; } = string.Empty;

        public string ToUnit { get; set; } = string.Empty;
    }
}
