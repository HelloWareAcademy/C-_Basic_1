using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1000;
            string itemName = "Cat";

            // if count is less than 1000
            if (!(itemName == "Cat" || count < 1000))
            {
                Console.WriteLine("You need to buy more");
            }
            // if count is equal to or greater than 1000
            else if (count == 1000)
            {
                Console.WriteLine("You have 1000 items.");
            }
            else
            {
                Console.WriteLine("You are good on the quantity");
            }


            //Switch: Can only be used for "equal" evaluation.
            string today = "Sun.";
            switch (today)
            {
                case "Sun.":
                case "Sat.":
                    Console.WriteLine("Yay Weekend!");
                    break;
                default:
                    Console.WriteLine("Sad day, keep working hard");
                    break;
            }

            //User should see "The item count is 10"
            Console.WriteLine("The item count is " + count);
            Console.WriteLine("The total count is " + count);

            // ? : ternary operatoer
            // condition ? first_expression : second_expression; 
            /*
             * if ( count > 1000)
             * {
             *  Console.WriteLine("Greater than 1000");
             * }else
             * {
             *  Console.WriteLine("Less than or equal to 1000");
             * }
             */
            Console.WriteLine(count > 1000 ? "Greater than 1000" : "Less than or equal to 1000");
        }
    }
}
