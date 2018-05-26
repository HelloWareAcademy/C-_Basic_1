using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a single line comment.
            /*
             * This is a comment block.
             */

            #region Variables
            //strict type
            //primitive types
            int count = 10;
            double pi = 3.14;
            string name = "HelloWare Academy";
            char a = 'a';

            // 50, "Hi", 'z', 6.66
            var x = "This is a string";
            var y = 8.88;

            //firstName declaration
            string firstName = "";
            int age = 0;
            #endregion

            //demo for firstName assignment.
            Console.WriteLine("Please input your first name:");
            //variable assignment
            firstName = Console.ReadLine();
            Console.WriteLine("You just input: " + firstName);
            Console.WriteLine("Please input your age: (natural number only)");
            //variable assignment
            try
            {
                //casting method 1: Convert.To
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your age is: " + age);
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid age input, please input natural number only!");
            }
            catch (OverflowException overflowException)
            {
                Console.WriteLine(overflowException.Message);
            }
            //catch all exception
            catch (Exception)
            {
                //
            }
            //Excute this whether there is an Exception or not.
            finally
            {
                //
            }


            //Casting method 2: (int)
            double aDouble = 4.9;
            int anInt = (int)Math.Round(aDouble);
            Console.WriteLine(anInt);


            Console.WriteLine(pi);
            Console.WriteLine(name);
            Console.WriteLine(x);


        }
    }
}
