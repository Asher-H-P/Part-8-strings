using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Part_8_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Aldworth";
            Console.WriteLine(name[0]);
            Console.WriteLine(name[name.Length - 1]);
            Console.WriteLine(name.Substring(3));
            Console.WriteLine(name.Substring(name.Length - 2));
            Console.WriteLine(name.Substring(3, 4));
            Console.WriteLine(name.Substring(1, name.Length - 2));
            Console.WriteLine(name[0] + name.Substring(5, 2));
            string yearString;
            int year = 1982;
            yearString = 1982 + "";
            Console.WriteLine(yearString);
            Console.WriteLine((name[7] + "").ToUpper() + name.Substring(1, 6) + (name[0] + "").ToLower());
            string name2 = "aldworth";
            if (name == name2)
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }
            if (name.Equals(name2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }
        }
    }
}
