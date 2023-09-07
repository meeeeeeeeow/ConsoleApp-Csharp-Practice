// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            double d = 5.5;
            string str1 = "Jaemin", str2 = "Jeno";

            // 5 spaces before print the number n (after -> -5)
            Console.WriteLine("int {0, 5} and double {1}", n, d);
            
            // just combine the string and var
            Console.WriteLine("int " + n + " and double " + d);

            // compare string
            bool eq1 = string.Equals(str1, str2);
            bool eq2 = str1.CompareTo(str2) == 0;
            Console.WriteLine("equal: {0}, {1}", eq1, eq2);

            Console.WriteLine("length: {0}", str1.Length);  // string length
            Console.WriteLine("substring: {0}", str1.Substring(0, 3));  // substring(startIdx, len)
            Console.WriteLine("start with: {0}", str1.StartsWith("Jae"));  // check start with, return true or false
        }
    }
}