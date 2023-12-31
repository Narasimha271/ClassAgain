using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAgain
{
    public class DataTypes
    {
        // C# has different kinds of Data types >> string, int, Char, boolean
            int Cat = 2;
            int bat = 1;
            string a = "test";
            string Mat2 = "test12345";
            string mat1 = "l";
            char c = 'a';
            bool ThisClass = true;
            bool YesterdayClass = false;

            public void add()
            {
                int D = Cat + bat;
                Console.WriteLine(D);
                Console.WriteLine(Cat + bat);
            }

            public void sub()
            {
                Console.WriteLine(Cat - bat);
            }

            public void kiran()
            {
                Console.WriteLine("test12345");
                Console.WriteLine(Mat2);
            }
    }
}
