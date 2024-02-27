using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAgain
{
    public class dice_game
    {
        public void DG() 
        {
            int Kittu = 20;
            int Devi = 20;
            Console.WriteLine("please enter who won the toss");

            string i = Console.ReadLine();
            if(i == "Kittu" || i == "kittu") 
            {
                while (true)
                {
                    int dice_roll = random();
                    Console.WriteLine($"Kittu rolls Dice {dice_roll}");
                    Devi = Devi - dice_roll;
                    Console.WriteLine($"Kittu health = {Kittu}");
                    Console.WriteLine($"Devi health = {Devi}");
                    if (Devi <= 0)
                    {
                        Console.WriteLine($"Devi health is {Devi} ");
                        Console.WriteLine($"Kittu won the game ");
                        break;
                    }
                    int dice_roll2 = random();
                    Console.WriteLine($"Devi rolls Dice {dice_roll2}");
                    Kittu = Kittu - dice_roll2;
                    Console.WriteLine($"Kittu health = {Kittu}");
                    Console.WriteLine($"Devi health = {Devi}");
                    if (Kittu <= 0)
                    {
                        Console.WriteLine($"Kittu health is {Kittu} ");
                        Console.WriteLine($"Devi won the game ");
                        break;
                    }
                }
            }

            if (i == "Devi" || i == "devi") 
            {
                while (true)
                {
                    int dice_roll2 = random();
                    Console.WriteLine($"Devi rolls Dice {dice_roll2}");
                    Kittu = Kittu - dice_roll2;
                    Console.WriteLine($"Kittu health = {Kittu}");
                    Console.WriteLine($"Devi health = {Devi}");
                    if (Kittu <= 0)
                    {
                        Console.WriteLine($"Kittu health is {Kittu} ");
                        Console.WriteLine($"Devi won the game ");
                        break;
                    }
                    int dice_roll = random();
                    Console.WriteLine($"Kittu rolls Dice {dice_roll}");
                    Devi = Devi - dice_roll;
                    Console.WriteLine($"Kittu health = {Kittu}");
                    Console.WriteLine($"Devi health = {Devi}");
                    if (Devi <= 0)
                    {
                        Console.WriteLine($"Devi health is {Devi} ");
                        Console.WriteLine($"Kittu won the game ");
                        break;
                    }
                }
            }
           
        }

        public int random() 
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
    }
}
