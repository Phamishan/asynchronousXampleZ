using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var tankTask = tankBil();
            var pølseTask = pølseKøb();

            Task.WaitAll(tankTask, pølseTask);
        }
        internal class Calculate
        {
            public event EventHandler? HalfDone;
            public int doCalculation(int id)
            {
                Console.WriteLine($"Tanking startet {id} på Thread {Thread.CurrentThread.ManagedThreadId}");

                int noOfChecks = 0;
                //4 sec of dummy work
                var endTime1 = DateTime.Now.AddSeconds(5);
                while (DateTime.Now < endTime1)
                {
                    noOfChecks++;
                }

                HalfDone?.Invoke(this, new EventArgs());

                var endTime2 = DateTime.Now.AddSeconds(5);
                while (DateTime.Now < endTime2)
                {
                    noOfChecks++; 
                }
                Console.WriteLine($"Tanking slut {id} færdig på Thread{Thread.CurrentThread.ManagedThreadId}");
                return noOfChecks;
            }
        }

        static async Task tankBil()
        {
            /*  Console.WriteLine("Tanking startet");
              await Task.Delay(2000);
              Console.WriteLine("Halfway through");
              await awaitForSec(2);
              Console.WriteLine("Tanking sluttet");*/

              var test = new Calculate();

            test.doCalculation(1);
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
                var endTime1 = DateTime.Now.AddSeconds(s);
                while (DateTime.Now < endTime1)
                {

                }
            });
        }
    }
}
