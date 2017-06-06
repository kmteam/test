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
            sName = CapitalizeName(sName);
            Console.WriteLine("Press 'Q' to quit");
            do
            {
                SayHello(sName);
            } while (Console.ReadKey().Key != ConsoleKey.Q );

			Console.WriteLine("Bye!");
        }

        private static void SayHello(String sName) {
            Console.WriteLine("Hi '{0}'",sName);
        }

        private static String CapitalizeName(String Name) {

            if (String.IsNullOrWhiteSpace(Name)) {
                return Name;
            }
            String capName = Name.ToLower();
            capName = capName.Substring(0, 1).ToUpper() + capName.Substring(1, capName.Length - 1);
            return capName;
        }
    }
}
