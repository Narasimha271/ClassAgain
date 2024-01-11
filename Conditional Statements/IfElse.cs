﻿using System;
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

            Console.WriteLine("Please enter addition or subtraction or multiplication or division");
            string input = Console.ReadLine();

            if (input == "addition")
            {
                Console.WriteLine(a + b);
            }

            else if (input == "multiplication")
            {
                Console.WriteLine(a * b);
            }

            else if (input == "subtraction")
            {
                Console.WriteLine(a - b);
            }

            else if (input == "division")
            {
                Console.WriteLine(a / b);
            }

            else
            {
                Console.WriteLine("Given the wrong input, Please run the program again");
            }
        }

        public void switchCaseCondition()
        {
            Console.WriteLine("Please enter first number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter second number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter addition or subtraction or multiplication or division");
            string input = Console.ReadLine();

            switch (input)
            {
                case "addition":
                    Console.WriteLine(a + b);
                    break;

                case "subtraction":
                    Console.WriteLine(a - b);
                    break;

                case "division":
                    Console.WriteLine(a / b);
                    break;

                case "multiplication":
                    Console.WriteLine(a * b);
                    break;

                default:
                    Console.WriteLine("Given the wrong input, Please run the program again");
                    break;
            }
        }

        public void simpleswitchCaseCondition()
        {
            switch ("Test3")
            {
                case "Test1":
                    Console.WriteLine("Test1");
                    Console.WriteLine("Test1");
                    break;

                case "Test2":
                    Console.WriteLine("Test2");
                    Console.WriteLine("Test2");
                    break;

                default:
                    Console.WriteLine("Given the wrong input, Please run the program again");
                    break;
            }
        }
    }
}
