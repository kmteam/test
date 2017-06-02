using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                SayHello();
            } while (Console.ReadKey().Key != ConsoleKey.Q );

	    Console.WriteLine("Bye!");
        }

        private static void SayHello() {
            Console.WriteLine("Hi world!");
        }
    }
}
