using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Project 2
            //Write a C# program to find the perfect numbers from n1 to n2
            //The Input: n1 and n2
            //The Output: The list of perfect numbers from n1 to n2
            // Example: For the input numbers: n1 = 5 and n2 = 30, the output should be //6 //28
            int n1, n2;
            Console.WriteLine("enter n1");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter n2");
            n2 = Convert.ToInt32(Console.ReadLine());
            for(int i = n1; i <= n2;i++)
            {
                if(isperfect(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool isperfect(int n)
        {
            int sum = 0;
              for  ( int i = 1; i < n; i++)
            {
                if(n % i == 0 )
                {
                    sum += i;
                }

            }
            return sum == n;
        }
    }
}
