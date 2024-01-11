using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAgain
{
    public class calculatorprogram
    {
        public void calculator() 
        {
            Console.WriteLine("please enter firstnumber");
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter secondnumber");
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter add or sub or mul or div");
            string input = Console.ReadLine();
            switch (input) 
            {
                case "add":
                    Console.WriteLine($"addition of 2 numbers is {firstnumber + secondnumber}");
                    break;
                case "sub":
                    Console.WriteLine($"subtraction of 2 numbers is ({firstnumber-secondnumber})");
                    break;
                case "mul":
                    Console.WriteLine($"multiplication of 2 numbers is {firstnumber *secondnumber}");
                    break;
                case "div":
                    Console.WriteLine($"division of 2 numbers is {firstnumber/secondnumber}");
                    break;

                default: Console.WriteLine("wrong input");
                    break;
            }
        }
    }
}
