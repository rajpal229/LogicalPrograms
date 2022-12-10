using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class Stopwatch
    {
        DateTime start_time;
        public void Start()
        {
            start_time = DateTime.Now;
            Console.WriteLine("Stopwatch has started ");
            Console.WriteLine("press 0 to stop the watch ");
            Selection();

        }
        public void Stop(DateTime start_time)
        {
            long minutes, seconds, milli;
            double elapsed_secs;
            double elapsed_time;
            DateTime end_time = DateTime.Now;
            elapsed_time = ((TimeSpan)(end_time - start_time)).TotalMilliseconds;
            minutes = Convert.ToInt64((elapsed_time / 1000) / 60);
            elapsed_secs = ((elapsed_time / 1000) % 60);
            seconds = Convert.ToInt64(elapsed_secs);
            milli = Convert.ToInt64((elapsed_secs - seconds) * 10);
            Console.WriteLine("Stop watch has been stopped");
            Console.WriteLine($"{minutes} minutes {seconds} seconds and {milli} ms");
        }
        public void Selection()
        {
            int selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    //start stop watch
                    Start();
                    break;
                case 2:
                    // stopping stopwatch
                    Stop(start_time);
                    break;
                default:
                    //invalid selection
                    Console.WriteLine("Invalid selection made.");
                    break;
            }
        }
        public void StimulateStopWatch()
        {
            Console.WriteLine("Press 1. to Start Stopwatch");
            Selection();
        }
    }
}
