using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebServiceAssignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ThingsController : ControllerBase
    {
        private readonly Stopwatch _stopwatch;
        private readonly List<Thing> _things;

        public ThingsController()
        {
            _stopwatch = new Stopwatch();
            _stopwatch.Start();

            _things = new List<Thing>
            {
                new Thing(1, "kremrole", 4),
                new Thing(2, "plechovka", 10, 500, true),
                new Thing(3, "telefon", 12, 202.22, false),
                new Thing(4, "klavir", 200, 107.5, true),
                new Thing(5, "vata", 30, null, false)
            };
        }

        [HttpGet]
        public ActionResult<List<Thing>> Things()
        {
            return _things;
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Thing> Things(int id)
        {
            try
            {
                return _things.Where(t => t.ID == id).Single();
            }
            catch (InvalidOperationException)
            {
                return NotFound();
            }
        }

    }
}