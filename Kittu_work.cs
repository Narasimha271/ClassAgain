using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAgain
{
    public class Kittu_work
    {

        public class program3
        {
            public void mult_of_2numbers(int a, int b)
            {
                Console.WriteLine("the multiplication of 2 numbers is" + (a + b));
            }
            public void mult_of_2numbers(string a, int b)
            {
                Console.WriteLine("the multiplication of 2 numbers is" + (a + b));
            }

            public void div_of_2numbers(int a, int b)
            {
                Console.WriteLine("the div of 2 numbers is " + a / b);
            }

        }
        public class program4
        {
            public void mult_of_2_number_by_inputs()
            {
                Console.WriteLine("Please enter a value for 1st number");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter a value for 2nd number");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The mult of 2 numbers is " + (a * b));
            }

            public void div_of_2numbers_by_input()
            {
                Console.WriteLine("Please enter a value for 1st number");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter a value for 2nd number");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The div of 2 numbers is " + (a / b));
            }
        }
    }
}
