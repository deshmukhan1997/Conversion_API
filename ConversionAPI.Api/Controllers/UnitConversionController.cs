using ConversionAPI.Application.DTOs;
using ConversionAPI.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace ConversionAPI.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UnitConversionController : ControllerBase
    {
        private readonly IUnitConversionService _conversionService;

        public UnitConversionController(
            IUnitConversionService conversionService)
        {
            _conversionService = conversionService;
        }

        [HttpPost]
        public ActionResult<UnitConversionResponse> Convert(
            [FromBody] UnitConversionRequest request)
        {
            try
            {
                var response = _conversionService.Convert(request);
                return Ok(response);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }
}
