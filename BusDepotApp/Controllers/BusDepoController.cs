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
        private readonly IBusDepoService _busDepoService;
        public BusDepoController(IBusDepoService busDepoService)
        {
            _busDepoService = busDepoService;
        }
        [HttpGet]
        public IActionResult GetAllBusInfo()
        {
            var busesFromRepo= _busDepoService.GetAllBus();
            return Ok(busesFromRepo);
        }
        [HttpGet("{busId}")]
        public IActionResult GetBusInfo(int busId)
        {
            var busFromRepo= _busDepoService.GetBus(busId);
            return Ok(busFromRepo);
        }

        [HttpGet("{busId}/Location")]
        public IActionResult GetBusLocation(int busId)
        {
             var busLocation=_busDepoService.GetBusLocation(busId);
            return Ok(busLocation);
        }

        [HttpGet("{busid}/Maintanence")]
        public IActionResult GetBusMaintainenceInfo(int busId)
        {
            var busMaintaineceInfo = _busDepoService.CalculateTimeToMaintainence(busId);
            return Ok(busMaintaineceInfo);
        }

        [HttpGet("{busid}/FuelConsumption")]
        public IActionResult GetFuelConsumption(int busId)
        {
            var busFuelConsumptionInfo = _busDepoService.GetFuelConsumptionPercentage(busId);
            return Ok(busFuelConsumptionInfo);
        }

    }
}