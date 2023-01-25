using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            tankBil Bil = gasstation();
            Console.WriteLine("Bil is tanket");

            stoevsugeBil bilInt = await suger();
            findSF(bilInt);

            Console.WriteLine("Færdig");
            
            koebeHotdog hotdog = spisHD();
            Console.WriteLine("Nom nom nom, hotdog is spiset");
            
            
            snakke samtale = newFriend();
            Console.WriteLine("Hej med dig jeg hedder Kaj");
        }

        private static tankBil gasstation()
        {
            Console.WriteLine("Tanker bil");
            return new tankBil();
        }

        private static void findSF(stoevsugeBil bilInt)
        {
            Console.WriteLine("Wwwwww");
            Task.Delay(3000).Wait();
        }
        private static stoevsugeBil suger()
        {
            Console.WriteLine("Finder støvsuger");
            Task.Delay(1000).Wait();
            Console.WriteLine("Start støvsuger");
            Task.Delay(3000).Wait();
            return new stoevsugeBil();
        }

        private static koebeHotdog spisHD()
        {
            Console.WriteLine("Køber hotdog");
            Task.Delay(3000).Wait();
            return new koebeHotdog();
        }

        private static snakke newFriend()
        {
            Console.WriteLine("Hej med dig Kaj, samtale is snakket");
            Task.Delay(3000).Wait();
            return new snakke();
        }

    }
}
