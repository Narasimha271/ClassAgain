using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAgain.Challenges
{
    public class arracyschallanges
    {
        // find the duplicate numbers and remove them from the collection and print the remaining numbers
        int[] arrayofNumbers = { 1, 3, 1, 5, 7, 5, 9, 2, 4, 6, 2, 1, 4, 5 };
        public void numberswithourDuplicates() 
        {
            Array.Sort(arrayofNumbers);

            // 1, 1, 1, 2, 2, 3, 4, 4, 5, 5, 5, 6, 7, 9 
            // 0, 0, 1, 0, 2, 3, 0, 4, 0, 0, 5, 6, 7, 9 
            //arrayofNumbers[arrayofNumbers.Length -1]
            //arrayofNumbers[13] = 9
            for (int i=0; i< arrayofNumbers.Length; i++) 
            {
                if ((i + 1) != arrayofNumbers.Length)
                {
                    if (arrayofNumbers[i] == arrayofNumbers[i + 1]) //arrayofNumbers[13] == arrayofNumbers[i+1]
                    {
                        Array.Clear(arrayofNumbers, i, 1);
                    }
                }
            }
                Array.Sort(arrayofNumbers);
            // 0, 0,  0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 7, 9 
            foreach (int number in arrayofNumbers) 
            {
                if (number != 0) 
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
