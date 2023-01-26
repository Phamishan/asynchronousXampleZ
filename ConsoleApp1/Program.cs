using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    internal class tankBil { }
    internal class stoevsugeBil { }
    internal class koebeHotdog { }
    internal class snakke { }

    class Program
    {
        static async Task Main(string[] args) 
        {
            var tankTask = tankBil();
            var pølseTask = pølseKøb();

            Task.WaitAll(tankTask, pølseTask);
        }

        static async Task tankBil()
        {
            Console.WriteLine("Tanking startet");
            await awaitForSec(5);
            Console.WriteLine("Tanking sluttet");
        }

        static async Task pølseKøb()
        {
            Console.WriteLine("Bestilt pølse");
            await awaitForSec(2);
            Console.WriteLine("Pølse modtaget");
        }

        static async Task awaitForSec(int s)
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"test: {Thread.CurrentThread.ManagedThreadId}");
                var endTime1 = DateTime.Now.AddSeconds(s);
                while (DateTime.Now < endTime1)
                {

                }
            });
        }
    }
}
