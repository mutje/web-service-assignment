using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceAssignment
{
    public class RunningTimeService
    {
        private readonly Stopwatch _stopwatch;

        public double RunningTimeSeconds { get => _stopwatch.Elapsed.TotalSeconds; }

        public RunningTimeService()
        {
            _stopwatch = new Stopwatch();
            _stopwatch.Start();
        }
    }
}
