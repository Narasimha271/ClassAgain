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
            return c;
        }

        public int sub(int a, int b)
        {
            int d = a - b;
            return d;
        }

        public void mul() 
        {
            MethodWithOutput obj = new MethodWithOutput();
            Console.WriteLine(obj.add(1, 2) * obj.sub(1, 2));
        }

        public void div() // print sum of 2nums and sub of 2 nums
        {
            MethodWithOutput obj = new MethodWithOutput();
            Console.WriteLine(obj.add(1, 2));
            Console.WriteLine(obj.sub(1, 2));
            Console.WriteLine(obj.add(1, 2) / obj.sub(1, 2));

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
