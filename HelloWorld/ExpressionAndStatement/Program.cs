using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionAndStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //statements ending with ;
            double x = 1.11;
            double y = 2.11;
            double z = 3.11;

            // statements ending with block(brackets)
            if (x > 10)
            {
                
            }
            double a = x - y;
            double b = x * y;
            double c = x / y;
            double d = x + y;

            //integer division 
            int intA = 5;
            int intB = 9;

            //      double    -----int----
            double quotient = intB / intA; //==1

            Console.WriteLine(quotient);
        }
    }
}
