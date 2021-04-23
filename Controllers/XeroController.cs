using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using xero_api.Services;

namespace xero_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class XeroController : ControllerBase
    {
        private readonly IXeroService _xeroService;

        public XeroController(IXeroService XeroService)
        {
            _xeroService = XeroService;
        }

        [HttpGet("GetOrganizations")]
        public async Task<IActionResult> GetOrganizations()
        {
            try
            {
                return Ok(await _xeroService.GetOrganizations());
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, "error occured.");
            }
        }
    }
}
