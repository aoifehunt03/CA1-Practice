namespace Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            MenuView();
        }



        static void MenuView()
        {
            Console.WriteLine("Menu: \n");
            Console.WriteLine("1. Calculate Gross Pay \n2. Print Session Statistics \n3. Exit \n");
            Console.Write("Enter Choice : ");
            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
                GrossPay();
            else if (userChoice == 2)
            {

            }
            else if (userChoice == 3)
                Console.WriteLine("You have exited the menu");
        }


        static string[] names = new string[10];
        static double[] wages = new double[10];

        static void GrossPay()
        {

            //initialising the variables for the user input menu
            string status = "";
            int years = 0;
            int hours = 0;


            for (int i = 0; i < names.Length; i++)
            {
                //user input menu view
                Console.Write($"{"\nEnter Name",-20} {": ",-10}");
                names[i] = Console.ReadLine();
                Console.Write($"{"Status (W/H)",-20} {": ",-10}");
                status = Console.ReadLine();
                Console.Write($"{"Enter Hours",-20} {": ",-10}");
                hours = int.Parse(Console.ReadLine());
                Console.Write($"{"Enter Years",-20} {": ",-10}");
                years = int.Parse(Console.ReadLine());


                wages[i] = Wages(status, hours, years);

                Console.WriteLine($"\n{names[i]} you worked {hours} hours and your wages are {wages[i]:c}\n\n");
                MenuView();

            }
        }

        static double Wages(string status, int hours, int years)
        {
            // weekly wage variables
            int overtime = 15;                      // overtime pay per hour
            double threeYearService = 0.1;          // 10% increase in pay
            int weekPay = 500;                      // for a 40 hour week
            double wageAmount = 0;                  // initialise the wageAmount

            // hourly wage variables
            int hourlyRate = 12;


            // assume that no worker works under 40 hours
            if (status == "w" || status == "W")
            {
                if (hours > 40)
                {
                    wageAmount = ((hours - 40) * overtime) + weekPay;
                }
                else if (hours == 40)
                {
                    wageAmount = weekPay;
                }
            }

            else if (status == "h" || status == "H")
            {
                wageAmount = hours * hourlyRate;
            }

            if (years > 3)
            {
                wageAmount = wageAmount + (wageAmount * threeYearService);
            }

            return wageAmount;
        }
    }
}