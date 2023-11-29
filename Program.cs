using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klaseIObjekti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zrakoplov x380=new Zrakoplov("Airbus", 2000, 6000);

            Console.Write(x380.ToString());

            Zrakoplov C162 = new Zrakoplov("Cessna Skycatcher", 75, 870);

            Console.Write(C162.ToString());

            Zrakoplov PC21 = new Zrakoplov("Pilatus", 1200, 1333);

            Console.Write(PC21.ToString());

            Console.ReadKey();
        }
    }
}
