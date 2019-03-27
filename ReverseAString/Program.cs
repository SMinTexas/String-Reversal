using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a phrase or sentence to reverse: ");
            String s = Console.ReadLine();

            if (s.Length == 0)
                Console.WriteLine("You must enter a string to proceed.");
            else
            {
                char[] arr = s.ToCharArray();
                Array.Reverse(arr);
                Console.WriteLine(arr);
            }

            Console.Read();
        }
    }
}
