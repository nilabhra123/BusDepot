using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusDepotApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusDepotApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusDepoController : ControllerBase
    {
        public BusDepoController(IBusDepoService busDepoService)
        {

        }
        [HttpGet]
        public IActionResult GetAllBusInfo()
        {

            return Ok();
        }
        [HttpGet]
        public IActionResult GetBusInfo(int busId)
        {

        }

        [HttpGet()]
        public IActionResult GetBusLocation(int busId)
        {
            return Ok();
        }

        public IActionResult GetBusMaintainenceInfo(int busId)
        {

            return Ok();
        }

    }
}