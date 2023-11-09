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
            Console.WriteLine(name.Replace("d", ""));
            //(name.Contains("and"));
            //(name.IndexOf("and") + 1);
            //(name.Insert(3, "and");
            //(name.Replace("f", ""));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Please input your first name: ");
            string frstName = Console.ReadLine().ToLower();
            Console.Write("Please input your last name: ");
            string lstName = Console.ReadLine().ToLower();
            Console.Write("Please input your student number: ");
            string stdntNmbr = Console.ReadLine().ToLower();
            Console.Write("Your new email address is: ");
            Console.WriteLine(lstName.Substring(0, 3) + frstName.Substring(0, 3) + stdntNmbr.Substring(6, 3) + "@parkside.ca");
            Console.WriteLine();
            string backwards;
            string[] reverseName = new string[0];
            reverseName[0] = frstName.ToUpper() + lstName;
            Console.WriteLine(reverseName[0]);
            for (int i = 0; i < reverseName[0].Length; i++)
            {
                Console.Write(reverseName[reverseName.Length - i - 1]);
            }
        }
    }
}
