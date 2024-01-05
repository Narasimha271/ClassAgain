using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAgain
{
    public class Concatination
    {
        public void operatorConcatination() 
        {
            string Firstname = "Narasimha";
            string Lastname = "Peddapalli";
            int amount = 100;
            Console.WriteLine(Firstname+ " " + Lastname+ " Has the amount of "+ amount);
        }

        public void Concatinationusinginputs() 
        {
            Console.WriteLine($"Please give the user first name");
            string Firstname = Console.ReadLine();

            Console.WriteLine($"Please give the user Last name");
            string Lastname = Console.ReadLine();

            Console.WriteLine($"please enter the user balance");
            int amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Firstname +  Lastname +"has the amount of " + amount);
        }

        public void Concatinationusingdollar()
        {
            string Firstname = "Narasimha";
            string Lastname = "Peddapalli";
            int amount = 100;

            Console.WriteLine($"{Firstname} {Lastname} has the amount of {amount}");
             
        }

        public void Concatinationusingdollarwithinputs()
        {
            Console.WriteLine($"Please give the user first name");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Please give the user Last name");
            string Lastname = Console.ReadLine();

            Console.WriteLine("please give the user amount");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{FirstName} {Lastname} has the amount of {a}");

        }
    }
}
