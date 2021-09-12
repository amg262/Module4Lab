using System;

namespace Module4Lab
{
    class ProgramJob
    {
        static double Job()
        {
            double total = 0;
            double moneyEarned = 0;
            int daysWorked = 0;
            int daysCounted = 0;
            int totalPennies = 0;
            int penniesEarned = 0;
            double outputMoney = 0;

            Console.WriteLine("Enter days worked>");
            Int32.TryParse(Console.ReadLine(), out daysWorked);

            if (daysWorked >= 1)
            {
                penniesEarned += 1;
                totalPennies += 1;
                daysCounted += 1;
                moneyEarned += penniesEarned;

                Console.WriteLine($"Pennies earned on Day {daysCounted}: {penniesEarned}");

                while (daysCounted < daysWorked)
                {

                    penniesEarned *= 2;
                    moneyEarned += penniesEarned;
                    //totalPennies += penniesEarned;
                    
                    daysCounted += 1;
             

                    Console.WriteLine($"Pennies earned on Day {daysCounted}: {penniesEarned}");

                }
                
                outputMoney = moneyEarned / 100;

                Console.WriteLine($"Total: {outputMoney:C}");

            }
            else
            {
                Console.WriteLine("Error: Invalid number");
            }
           
            return total;
        }


        static void Main2(string[] args)
        {

            Job();

        }
    }
}