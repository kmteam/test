﻿using System;
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
                Console.WriteLine("Hi world!");
            } while (Console.ReadKey().Key != ConsoleKey.Q );

	    Console.WriteLine("Bye!");
        }
    }
}
