using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassAgain
{
    public class Yesterdaysassignment
    {
        public void fullname()
        {
            Console.WriteLine("please enter firstname");
            string firstname = Console.ReadLine();
            Console.WriteLine("please enter lastname");
            string lastname = Console.ReadLine();

            Yesterdaysassignment obj = new Yesterdaysassignment();
            obj.switchforfulname(firstname, lastname);
        }
        public void switchforfulname(string firstname, string lastname)
        {
            Console.WriteLine("please enter yes if you want to print fullname, Please enter no if you don't want to");
            string condition = Console.ReadLine();
            switch (condition)
            {
                case "yes":
                    Console.WriteLine($"Full name is {firstname} {lastname}");
                    break;
                case "No":
                    Console.WriteLine($"Thank you");
                    break;
                default:
                    Console.WriteLine("please enter yes or No");
                    break;
            }
        }
    }
}
