using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class SumOfDigit
    {
        static void Main(string[] args)
        {
            int sum = 0, rem;
            Console.WriteLine("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());

            while (n > 0)
            {
                rem = n % 10;
                sum= sum + rem;
                n = n / 10;
            }
            Console.WriteLine("Sum is:"+sum);

        }
    }
}
