using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenDigitFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Fibonacci sequence is defined by the recurrence relation:
            // Fn = Fn−1 + Fn−2, where F1 = 1, F2 = 1, F3 = 2, .... and F12 = 144.F12 is the first term to contain three digits.
            //What is the index of the first term in the Fibonacci sequence to contain 10 digits ?
             
            int num1 = 0, num2 = 1, sum = 0;
            ArrayList fib = new ArrayList();

            while (sum < 999999999)
            {
                sum = num1 + num2;               
                fib.Add(sum);
                num1 = num2;
                num2 = sum;
            }
            
            Console.WriteLine($"\nThe first term in the Fibonacci sequence to contain 10 digits is F{fib.Count}.");

        }
    }
}
