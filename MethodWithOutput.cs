using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAgain
{
  
    public class MethodWithOutput
    {

        public int add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
            return c;
        }

        public int sub(int a, int b)
        {
            int d = a - b;
            Console.WriteLine(d);
            return d;
        }

        public void addition() 
        {
            Console.WriteLine(" Please enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Please enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            int e = add(a, b) + sub(a, b);
            Console.WriteLine(e);
        }
    }
}
