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
            int num = int.Parse(Console.ReadLine());  // parsing input (e.g., double.Parse(), char.Parse(), etc.)
            Console.WriteLine("input number: {0}", num);
            Console.WriteLine("------------------------------------");

            // array
            int[] arr1 = new int[3];
            int[] arr2 = new int[3] { 5, 6, 7 };
            int[] arr3 = new int[] { 5, 6, 7 };
            int[] arr4 = { 5, 6, 7 };
            int[,] arr2D = new int[3, 4];  // declare 2d array using [,] -> arr2D[i, j]

            int[][] arrDynamic = new int[3][];  // declare n-d array with defferent dimension -> arrDynamic[i][j]
            arrDynamic[0] = new int[4] {0, 1, 2, 3};
            arrDynamic[1] = new int[8] {8, 7, 6, 5, 4, 3, 2, 1};
            arrDynamic[2] = new int[2] {5, 6};
            Console.WriteLine("array element: {0}", arrDynamic[1][5]);

            Console.Write("for array elements: ");
            for (int i=0; i<arr2.Length; i++)  // array.Length
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();

            Console.Write("foreach array elements: ");
            foreach (int ele in arr2)  // foreach (dataType ele in arr)
            {
                Console.Write(ele + " ");
            }
            Console.WriteLine();

            // array methods
            int[] arr5 = { 10, 15, 20, 30, 35, 40, 45 };
            int target = 20;
            int ans = Array.BinarySearch(arr5, target);  // build-in binary search
            if (ans < 0) Console.WriteLine("number not exist");
            else Console.WriteLine("the target position is index {0}", ans);

            int[] arr6 = { 16, 18, 9, 3, 24, 7 };
            Array.Sort(arr6);  // build-in sorting
            Console.Write("sorting array: ");
            for (int i=0; i<arr6.Length; i++)
            {
                Console.Write(arr6[i] + " ");
            }
            Console.WriteLine();
            
            Array.Reverse(arr6);  // build-in reverse
            Console.Write("reverse array: ");
            for (int i = 0; i < arr6.Length; i++)
            {
                Console.Write(arr6[i] + " ");
            }
            Console.WriteLine("\n------------------------------------");
        }
    }
}