using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebServiceAssignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimeController : ControllerBase
    {
        private readonly RunningTimeService _runningTimeService;

        public TimeController(RunningTimeService runningTimeService)
        {
            _runningTimeService = runningTimeService;            
        }

        [HttpGet]
        public ActionResult<int> GetRunningTimeSeconds()
        {
            return (int) _runningTimeService.RunningTimeSeconds;
        }
    }
}