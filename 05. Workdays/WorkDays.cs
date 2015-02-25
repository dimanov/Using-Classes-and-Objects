/*
 * Problem 5. Workdays
 * Write a method that calculates the number of workdays between today and given date, passed as parameter.
 * Consider that workdays are all days from Monday to Friday except a fixed list of public holidays 
 * specified preliminary as array.
 */

using System;

class WorkDays
{
    static void Main()
    {
        Console.WriteLine("This program calculates the number of the working days between today and a given date.");
        Console.WriteLine("Please enter a date in the following format: dd.mm.yyyy");
        var now = DateTime.Now;
        var givenDate = DateTime.Parse(Console.ReadLine(), null);

        //Console.WriteLine(now);
        //Console.WriteLine(givenDate);

        TimeSpan diffDays = now.Subtract(givenDate);
        int number = 0;
        var currDate = new DateTime();
        for (int i = 1; i <= givenDate.Subtract(now).Days; i++)
        {
            currDate = now.Date.AddDays(i);
            Console.WriteLine(currDate.DayOfWeek);

            if (currDate.DayOfWeek.ToString() == "Saturday" || currDate.DayOfWeek.ToString() == "Sunday")
            {

            }
            else 
            {
                number++;
            }

        }

        Console.WriteLine("The number of working days till {0} are {1}", givenDate.Date, number);

    }
}