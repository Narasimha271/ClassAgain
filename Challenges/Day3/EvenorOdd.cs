using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAgain.Challenges.Day3
{
    public class EvenorOdd
    {
        //Write a program that takes an integer as input and prints whether it is even or odd.
        public void methodeven()
        {
            double i = Convert.ToInt64(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine($"The given number {i} is Even");
            }
            else
            {
                Console.WriteLine($"The given number {i} is Odd");
            }
        }
    }
}
