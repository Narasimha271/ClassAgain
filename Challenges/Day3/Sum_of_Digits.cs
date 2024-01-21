using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAgain.Challenges.Day3
{
    public class Sum_of_Digits
    {
        public void sum_of_Digits(int input) //input = 3113
        {
            //Write a program to find the sum of the digits of a given integer. >> 3113 >> 3 + 1 + 1 + 3
            int Digits = 0;
            for (int i = input; i >0; i = i/10 )
            {
                Digits = Digits + (i % 10);
            }
            Console.WriteLine( Digits );



            /*
             *  initilization (i = input ) --> i =3113
             *  Condition check (i> 0) --> 3113 > 0 >> True
             *  {
             *      Digits = Digits + (i % 10); >>  Digits = Digits + (3113 % 10);
             *      Digits = Digits + (3113 % 10); >> Digits = 0+3; >> Digits = 3;
             *  }
             *  Counter >> (i =  i/10) >> i = 311
             *  Loop 1 finish 
             *  
             *  Loop2 start
             *  Condition check (i> 0) --> 311 > 0 --> True
             *  {
             *      Digits = Digits + (i % 10); >>  Digits = Digits + (311 % 10);
             *        Digits = 3 + (311 % 10); >> Digits = 3+1 
             *        Digits = 4
             *  }
             *  Counter >> (i =  i/10) >>  i = 311/10 -> i=31
             *  loop 2 finish
             *  
             *   Loop3 start
             *   Condition check (i> 0) --> 31>0 --> true
             *   {
             *      Digits = Digits + (i % 10); >>  Digits = Digits + (31 % 10);
             *        Digits = 4 + (31 % 10); >> Digits = 4+1 
             *        Digits = 5
             *  }
             *  Counter >> (i =  i/10) >>  i = 31/10 -> i=3
             *   loop 3 finish
             *   
             *  Loop4 start
             *   Condition check (i> 0) --> 3>0 --> true
             *   {
             *      Digits = Digits + (i % 10); >>  Digits = Digits + (3 % 10);
             *        Digits = 5 + (3 % 10); >> Digits = 5+3 
             *        Digits = 8
             *   }
             *   Counter >> (i =  i/10) >>  i = 3/10 -> i=0
             *     loop 4 finish
             *     
             *    Loop5 start
             *    Condition check (i> 0) --> 0>0 --> false
             *    Loop end
             */
        }
    }
}
