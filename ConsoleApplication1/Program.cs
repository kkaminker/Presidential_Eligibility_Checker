using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("How old are you?");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Were you born in the US? Enter y for yes and n for no.");
                String input = Console.ReadLine();
                Boolean bornCitizen;
                while (!input.Equals("y") && !input.Equals("Y") && !input.Equals("N") && !input.Equals("n"))
                {
                    Console.WriteLine("try again.");
                    input = Console.ReadLine();
                }
                if (input.Equals("y") || input.Equals("Y"))
                {
                    bornCitizen = true;
                }
                else
                {
                    bornCitizen = false;
                }


                Console.WriteLine("How many years have you resided in the US?");
                int yearsResided = int.Parse(Console.ReadLine());

                Console.WriteLine("How many times have you been elected?");
                int timesElected = int.Parse(Console.ReadLine());

                Console.WriteLine("Were you ever convicted? Enter y for yes and n for no.");
                input = Console.ReadLine();
                Boolean convicted;
                while (!input.Equals("y") && !input.Equals("Y") && !input.Equals("N") && !input.Equals("n"))
                {
                    Console.WriteLine("try again.");
                    input = Console.ReadLine();
                }
                if (input.Equals("y") || input.Equals("Y"))
                {
                    convicted = true;
                }
                else
                {
                    convicted = false;
                }

                Classes.EligibilityChecker eligible = new Classes.EligibilityChecker(age, bornCitizen, yearsResided, timesElected, convicted);
                if (eligible.isEligible())
                {
                    Console.WriteLine("You are eligible to become president!");
                }
                else
                {
                    Console.WriteLine("Sorry, you are not eligible to become president.");
                }

                Console.ReadKey();

            }
            else if (args.Length == 5)
            {
                int age = int.Parse(args[0]);
                Boolean borncit = Boolean.Parse(args[1]);
                int yearsResided = int.Parse(args[2]);
                int timesElected = int.Parse(args[3]);
                Boolean convicted = Boolean.Parse(args[4]);
                Classes.EligibilityChecker eligible = new Classes.EligibilityChecker(age, borncit, yearsResided, timesElected, convicted);
                if (eligible.isEligible())
                {
                    Console.WriteLine("You are eligible to become president!");
                }
                else
                {
                    Console.WriteLine("Sorry, you are not eligible to become president.");
                }

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Incorrect input--program terminating.");
                Environment.Exit(1);
            }

        }
    }
}
