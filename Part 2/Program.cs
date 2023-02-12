/*
 * aoife hunt
 * s00236573
 * classroom assessment 1
 * 11 02 2023
 * 
 * practicing: menus, 
 */

namespace Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuView();
        }

        static void MenuView()
        {
            Console.WriteLine("Menu: \n");
            Console.WriteLine("1. Calculate Gross Pay \n2. Print Session Statistics \n3. Exit \n");
            Console.Write("Enter Choise : ");
            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
                MenuView();
            else if (userChoice == 2)
                Console.WriteLine();
            else if (userChoice == 3)
                Console.WriteLine("You have exited the menu");
        }

        static void GrossPay()
        {
            //initialise the arrays
            double[] wage = new double[10];
            string[] clientName = new string[10];

            //user input menu view
            Console.Write($"{"\nEnter Name",-20} {" : "}");
            clientName[] = Console.ReadLine();
            Console.Write($"{"Status (W/H)",-20} {" : "}");
            string status = Console.ReadLine();
            Console.Write($"{"Enter Hours",-20} {" : "}");
            int hours = int.Parse(Console.ReadLine());
            Console.Write($"{"Enter Years",-20} {" : "}");
            int years = int.Parse(Console.ReadLine());

            //initialise the variables
            double wageRate;

            //weekly wage calculations
            if (status.ToLower() == "w")
            {
                wageRate = 500;

                if (hours == 40)
                {
                    wage = wageRate;
                }
                else if (hours > 40)
                {
                    wage = wageRate + (15 * (hours - 40));   //calculating overtime 
                }

                if (years > 3)
                {
                    wage = wageRate + (wageRate * 0.1);
                }


                Console.WriteLine($"{clientName} you worked {hours} hours and your wages are {wage:c}");
            }

            //hourly wage calculations
            else if (status.ToLower() == "h")
            {
                wage = 12 * hours;

                Console.WriteLine($"{clientName} you worked {hours} hours and your wages are {wage:c}");
            }
        }
    }
}