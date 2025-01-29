using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StopWatchApp
{
    internal class StopWatch
    {
        public void StopWatchTimer()
        {
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("Enter a command for Stopwatch Start/Stop: ");
            var userInput = Console.ReadLine();

            while (true)
            {
                
                if (userInput == null)
                {
                    Console.WriteLine("Enter a command for Stopwatch Start/Stop: ");
                    userInput = Console.ReadLine();
                }
                else if (userInput.ToLower() == "start")
                {
                    if (sw.IsRunning)
                    {
                        throw new InvalidOperationException("Stopwatch already running.");
                    }
                    sw.Start();
                    Console.WriteLine("Enter a command for Stopwatch Start/Stop: ");
                    userInput = Console.ReadLine();
                }
                else if (userInput.ToLower() == "stop")
                {

                    if (!sw.IsRunning)
                    { throw new InvalidOperationException("Stopwatch isn't running. please start stopwatch."); }
                    sw.Stop();
                    Console.WriteLine(sw.ElapsedMilliseconds);
                    Console.WriteLine(sw.Elapsed);
                    Console.WriteLine(sw.ElapsedTicks);
                    break;
                }
            }
        }
    }
}
