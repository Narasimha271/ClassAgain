using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAgain.Conditional_Statements
{
    public class IfElse
    {
        public void ifelseCondiotion() 
        {
            Console.WriteLine("Please enter first number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter second number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter addition or subtraction");
            string input = Console.ReadLine();

            if (input == "addition")
            {
                Console.WriteLine(a + b);
            }

            else if (input == "multiplication")
            {
                Console.WriteLine(a * b);
            }

            else 
            {
                Console.WriteLine("Please select either addition or subtraction"); 
            }



        }
    }
}
