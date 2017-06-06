using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
		/// <summary>
		/// Main method
		/// </summary>
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

		/// <summary>
		/// Says Hello message to somebody
		/// </summary>
        private static void SayHello(String sName) {
            Console.WriteLine("Hi '{0}'",sName);
        }

		/// <summary>
		/// Ensure name is first letter capitalized.
		/// </summary>
        private static String CapitalizeName(String Name) {

            if (String.IsNullOrWhiteSpace(Name)) {
                return Name;
            }
            String tmp = Name.ToLower();
            tmp = tmp.Substring(0, 1).ToUpper() + tmp.Substring(1, tmp.Length - 1);
            return tmp;
        }
    }
}
