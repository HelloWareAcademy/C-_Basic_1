using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatementPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            //#region
            string age = "";
            string firstName = "";
            string lastName = "";
            string gender = "";
            string greetGender = "";
            string greeting = "";
            var time = DateTime.Now.Hour;
            //#endregion

            Console.WriteLine("Please enter your first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name:");
            lastName = Console.ReadLine();
            Console.WriteLine("Please enter your age:");
            age = Console.ReadLine();
            Console.WriteLine("Please enter your gender:");
            gender = Console.ReadLine();
            greetGender = gender == "male" || gender == "Male" ? "Mr. " : "Miss ";

            greeting = time > 8 && time < 18 ? "Good day, " : "Good evening, ";
            Console.WriteLine(greeting + greetGender + lastName + ", Age " + age);
        }
    }
}
