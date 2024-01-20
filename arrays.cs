using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassAgain
{
    public class arrays
    {
        // arrays is a collection of similar type of elements 
        int[] apples = { 6, 2, 7, 58 , 91};
        string[] Pets = { "Tommy", "Leo", "Subramaniam"};
        

        public void areaOfRectangle() 
        {
            for (int i = 0;i <3; i++) 
            {
                Console.WriteLine(apples[i]);
            }

            foreach (int apple in apples) 
            {
                Console.WriteLine(apple);
            }
        }

        public void useofMethodsforArrays() 
        {
            // Sort() is used to sort an array in an assending order            
            Array.Sort(apples);
            foreach (int apple in apples)
            {
                Console.WriteLine(apple);
            }
            Array.Reverse(apples);
            foreach (int apple in apples)
            {
                Console.WriteLine(apple);
            }

            Array.Sort(Pets);
            foreach (string apple in Pets)
            {
                Console.WriteLine(apple);
            }
            Array.Reverse(Pets);
            foreach (string apple in Pets)
            {
                Console.WriteLine(apple);
            }

            Array.Clear(apples); // clears all the array
            foreach (int apple in apples)
            {
                Console.WriteLine(apple);
            }

            Array.Clear(apples, 0, 0); // clears the values form index to number of elements from that index
            foreach (int apple in apples)
            {
                Console.WriteLine(apple);
            }

            int index = Array.IndexOf(apples, 2);
            Console.WriteLine(index);
        }
    }
}
