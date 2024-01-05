using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAgain
{
    public class TypeCasting
    {
        // In implicit Casting the system automatically does the conversion
        // In ex[plicit Casting the user does the manual conversion
        public void implicitcasting() 
        {
            int a = 1;
            float b = a;
            Console.WriteLine(b);
        }

        public void explicitcasting()
        { 
            float b = 5.5f;
            int a = (int) b;
            Console.WriteLine(a);

            float v= (float)a;
        }

        public void explicitcastingUSINGMETHODS()
        {
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Console.ReadLine() + "is the number");
        }
    }
}
