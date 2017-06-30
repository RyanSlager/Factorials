using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            Console.WriteLine("Hello! Welcome to our Factorial Calculator! Please enter your name: ");
            string name = Console.ReadLine();

            while(cont == true)
            {
                

                Console.WriteLine($"{name}, please enter your a number between 1 and 10");
                string rawNum = Console.ReadLine();
                long parNum;

                while (!Int64.TryParse(rawNum, out parNum) || parNum < 1 || parNum > 10)
                {
                    Console.WriteLine($"{name}, please enter an integer between 1 and 10");
                    rawNum = Console.ReadLine();
                }

                Factorial(parNum);

                cont = Continue();
            }

        }

        public static void Factorial(long x)
        {
            long j = x;

            for (long i = (x - 1); i > 0; i--)
            {
                j = j * i;
            }

            Console.WriteLine(j);
        }

        public static Boolean Continue()
        {
            Boolean run;
            Console.WriteLine("Continue? Y/N");
            String answer = Console.ReadLine();

            if ((answer == "Y") || (answer == "y"))
            {
                run = true;
            }
            else if ((answer == "N") || (answer == "n"))
            {
                run = false;
                Console.WriteLine("Good Bye!");
            }
            else
            {
                Console.WriteLine("I'm sorry I don't understand. Let's try again");
                run = Continue();
            }
            return run;
        }
    }

}
