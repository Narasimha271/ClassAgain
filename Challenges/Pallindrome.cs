using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAgain.Challenges
{
    public class Pallindrome
    {
        public void pallindrome(string inputStirng) 
        {
            char[] Name = inputStirng.ToCharArray(); // I'm converting it into a character array and asssigning it to array Name 
            Array.Reverse(Name); // I'm reversing the array
            string reversedName = new string(Name); // I'm converting array of charachters into a string
            if (inputStirng == reversedName) // comparing orginal imput ot reversed input
            {
                Console.WriteLine("pallindrome");
            }
            else 
            { 
                Console.WriteLine("notpallindrome");
            }
        }
    }
}
