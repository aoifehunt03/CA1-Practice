/*
 * aoife hunt
 * s00236573
 * classroom assessment 1
 * 11 02 2023
 * 
 * practicing: methods, switch statements, math.ceiling rounding numbers, logic
 */

namespace part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //test cases display
            Console.WriteLine("Test[1] : Amount = 20, Service = excellent, Expected Answer = {0} ", CalculateTip(20, "excellent"));
            Console.WriteLine("Test[2] : Amount = 26.95, Service = good, Expected Answer = {0} ", CalculateTip(26.95, "good"));
        }

        public static int CalculateTip(double amount, string rating)
        {
            switch (rating.ToLowerInvariant())              // case insensitive
            {
                case "terrible":
                    double percent = 0;                     // just to initialise the variable
                    int tip = 0;                            // no tip so no calculation needed
                    return tip;
                case "poor":
                    percent = 0.05;
                    tip = (int)Math.Ceiling(percent * amount);
                    return tip;
                case "good":
                    percent = 0.1;
                    tip = (int)Math.Ceiling(percent * amount);
                    return tip;
                case "great":
                    percent = 0.15;
                    tip = (int)Math.Ceiling(percent * amount);
                    return tip;
                case "excellent":
                    percent = 0.2;
                    tip = (int)Math.Ceiling(percent * amount);
                    return tip;
                default:
                    return -1;                             // default returns -1 in the case of an invalid input
            }
        }
    }
}