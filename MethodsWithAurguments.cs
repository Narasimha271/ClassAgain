using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAgain
{
    public class MethodsWithAurguments
    {
        
        public void test() 
        {
            Console.WriteLine("Mehod with out Aurgument");
        }

        public void Test2(string Name)  // A method with Aurguments is a method with variables as input.
        {
            Console.WriteLine(Name);
        }

        public void add() 
        {
            Console.WriteLine(1+2);
        }

        public void add_of_2_Numbers(int a, int b) 
        {
            Console.WriteLine("The Addition result is ");
            Console.WriteLine(a + b);
        }

        public void add_of_2_number_by_inputs() 
        {
            Console.WriteLine("This is to Perform Addition");
            Console.WriteLine("Please enter a value for 1st number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a value for 2nd number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The addition of 2 numbers is " + (a + b));
        }
    }
}
