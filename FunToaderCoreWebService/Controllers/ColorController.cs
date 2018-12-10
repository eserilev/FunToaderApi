using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunToaderCoreWebService.Models;
using FunToaderCoreWebService.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FunToaderCoreWebService.Controllers
{
    [Route("api/[controller]")]
    public class ColorController : Controller
    {
        private readonly ColorService colorService;

        public ColorController(ColorService colorService)
        {
            this.colorService = colorService;
        }

        [HttpPost]
        public async Task<ActionResult> SendColorMessage([FromForm]ColorRequest request)
        {
            try
            {
                 var m = await colorService.SendCommand(request);
                 return Ok(m);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    
    }
}
