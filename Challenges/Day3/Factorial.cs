using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassAgain.Challenges.Day3
{
    public class Factorial
    {
        /*Write a program to calculate the factorial of a given number. 
         * The factorial of a non-negative integer n is the product of all positive integers less than or equal to n.*/
        public void factorial(int input) 
        {
            long factorial = 1;
            for (int i = input; i > 0; i--) 
            {
                factorial = factorial * (i); 
            }
            Console.WriteLine(factorial);


            //    for
            //    Initialization

            //    (Condition) // checks for condition and enter the loop if condition satisfies
            //    { 
            //        // execute statements
            //    }
            //    (Increment or decrement) // either increments or decrements the value
        }

    }
}
