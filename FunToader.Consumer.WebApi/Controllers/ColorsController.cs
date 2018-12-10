using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunToader.Domain.Business.Models.Media;
using FunToader.Orchestration.Core.Interfaces.Media;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace FunToader.Consumer.WebApi.Controllers
{

    [Produces("application/json")]
    [Route("api/Colors")]
    public class ColorController : Controller
    {
        
        private readonly IColorService colorService;

        public ColorController(IColorService colorService)
        {
            this.colorService = colorService;
        }

        [HttpPost]
        public async Task<ActionResult> SendColorMessage([FromForm]ColorRequest request)
        {
            try
            {
                var m = await colorService.SendArgbColorCommand(request);
                return Ok(m);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
           }
        }

    }
}