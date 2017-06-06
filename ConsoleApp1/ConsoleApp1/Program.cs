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
			String sName=String.Empty;
			
			Console.WriteLine("Type your name :");
			sName = Console.ReadLine();
			
            do
            {
                SayHello(sName);
            } while (Console.ReadKey().Key != ConsoleKey.Q );

			Console.WriteLine("Bye!");
        }

        private static void SayHello(String sName) {
            Console.WriteLine("Hi '{0}'",sName);
        }
    }
}
