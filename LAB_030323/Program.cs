using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LAB_030323
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string InPut = Console.ReadLine();

            if (Regex.IsMatch(InPut, @"^[A-Z,a-z,0-9]+@[A-Z,a-z,0-9]+\\.com$"))
                Console.WriteLine("This is e-mail.");

            else if (Regex.IsMatch(InPut, @"^(\+\d{1,2})(\s|.)(\d{3})(\s|.)(\d{3})(\s|.)(\d{4})"))
                Console.WriteLine("This is mobile number.");

            else Console.WriteLine("I don't know what is it.");

            Console.ReadKey();
        }
    }
}
