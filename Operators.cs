using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAgain
{
    public class Operators
    {
        public void Assignment() 
        {
            int b = 2;
            b += 3; // b = b + 3 >> b = 2 + 3 >> b = 5

            Console.WriteLine(b); // >> 5
            b -= 3; // b = b - 3 //  b = 5 - 3 >> b = 2

            Console.WriteLine(b); // 2
        }
    }
}
