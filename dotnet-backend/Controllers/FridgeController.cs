using dotnet_backend.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_backend.Controllers
{
    [ApiController]
    [Route("/api")]
    public class FridgeController : Controller
    {
        private readonly FridgeServices myService;

        public FridgeController(FridgeServices myService)
        {
            this.myService = myService;
        }

        [HttpGet("test")]
        public async Task<IActionResult> Test()
        {
            return StatusCode(418, myService.GetAllFridges());
            
        }
    }
}
