/* 16.3 Write an app that uses string method CompareTo to compare two strings input
  by the user. Output wether the first string is less than, equal to or greater
  than the second.
 */

using System;

namespace String_compare
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            string str2;

            Console.WriteLine("***The program will comapare two strings input*** \n");

            Console.WriteLine("Enter first string: ");
            str1 = Console.ReadLine();

            Console.WriteLine("Enter second string: ");
            str2 = Console.ReadLine();

            if (str1.CompareTo(str2) < 0)
            {
                Console.WriteLine("the first string is less than second string");
                Console.ReadLine();
            }
            else if (str1.CompareTo(str2) > 0)
            {
                Console.WriteLine("the first string is more than second string");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("the strings are equal");
                Console.ReadLine();
            }
        }
    }
}
