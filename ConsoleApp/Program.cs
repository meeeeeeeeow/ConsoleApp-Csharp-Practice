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
        enum DayOfWeek
        {
            Sun, Mon, Tue, Wed, Thu, Fri, Sat
        }

        static void Main(string[] args)
        {
            int n = 5;
            double d = 5.5;

            // 5 spaces before print the number n (after -> -5)
            Console.WriteLine("int {0, 5} and double {1}", n, d);
            
            // just combine the string and var
            Console.WriteLine("int " + n + " and double " + d);
            Console.WriteLine("------------------------------------");

            // compare string
            string str1 = "Jaemin", str2 = "Jeno";
            bool eq1 = string.Equals(str1, str2);
            bool eq2 = str1.CompareTo(str2) == 0;
            Console.WriteLine("equal: {0}, {1}", eq1, eq2);

            Console.WriteLine("length: {0}", str1.Length);  // string length
            Console.WriteLine("substring: {0}", str1.Substring(0, 3));  // substring(startIdx, len)
            Console.WriteLine("start with: {0}", str1.StartsWith("Jae"));  // check start with, return true or false
            Console.WriteLine("------------------------------------");

            // enum
            DayOfWeek today = DayOfWeek.Fri;
            Console.WriteLine("today: {0}", today);
            int numOfToday = (int)today;
            Console.WriteLine("today's number: {0}", numOfToday);
            Console.WriteLine("------------------------------------");

            // input data
            Console.WriteLine("enter a string...");
            string message = Console.ReadLine();
            Console.WriteLine("input string: {0}", message);

            Console.WriteLine("enter a number...");
            int num = int.Parse(Console.ReadLine());  // parse input integer
            Console.WriteLine("input number: {0}", num);
        }
    }
}