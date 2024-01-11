using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAgain
{
    public class loopingstatements
    {
        public void forloop()
        {
            for (int apples = 0; apples < 10; apples++) 
            {
                calculatorprogram obj = new calculatorprogram();
                obj.calculator();
            }
        }
    }
}
