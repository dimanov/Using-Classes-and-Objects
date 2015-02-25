/*
 * Problem 5. Workdays
 * Write a method that calculates the number of workdays between today and given date, passed as parameter.
 * Consider that workdays are all days from Monday to Friday except a fixed list of public holidays 
 * specified preliminary as array.
 */

using System;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

class WorkDays
{
    static void Main()
    {
        CultureInfo MyCultureInfo = new CultureInfo("bg-BG");

        string[] OfficialHolidays = { "01.01.2015", "02.01.2015", 
                                      "02.03.2015", "03.03.2015", 
                                      "10.04.2015", "13.04.2015",
                                      "01.05.2015", "06.05.2015",
                                      "21.09.2015", "22.09.2015",
                                      "24.12.2015", "25.12.2015",
                                      "31.12.2015"     
                                    };

        string[] WorkingHolidays = {"24.01.2015", "21.03.2015", 
                                    "12.09.2015", "12.12.2015"
                                   };

        var OfficialHolidaysList = new List<DateTime>();
        var WorkingHolidaysList = new List<DateTime>();
        try
        {
            OfficialHolidaysList = OfficialHolidays.Select(date => DateTime.ParseExact(date, "dd.MM.yyyy", MyCultureInfo)).ToList();
        }
        catch (FormatException)
        {
            Console.WriteLine("Unable to parse '{0}'", OfficialHolidays);
        }


        try
        {
            WorkingHolidaysList = WorkingHolidays.Select(date => DateTime.ParseExact(date, "dd.MM.yyyy", MyCultureInfo)).ToList();
        }
        catch (FormatException)
        {
            Console.WriteLine("Unable to parse '{0}'", WorkingHolidays);
        }



        Console.WriteLine("This program calculates the number of the working days between today and a given date.");
        Console.WriteLine("Please enter a date in the following format: dd.mm.yyyy");
        var now = DateTime.Now;
        var givenDate = DateTime.Parse(Console.ReadLine(), null);

        //Console.WriteLine(now);
        //Console.WriteLine(givenDate);

        //string[] lines = System.IO.File.ReadAllLines(@"..\Holidays.txt");
        int number = 0;
        var currDate = new DateTime();
        for (int i = 0; i <= givenDate.Subtract(now).Days; i++)
        {
            currDate = now.Date.AddDays(i);
            //Console.WriteLine(currDate.DayOfWeek);
            //Console.WriteLine(currDate.Date);
            if (currDate.DayOfWeek.ToString() == "Saturday" || currDate.DayOfWeek.ToString() == "Sunday")
            {

                if (WorkingHolidaysList.Any(x => x.Date == currDate))
                {
                    number++;
                }

            }
            else
            {
                if (!OfficialHolidaysList.Any(x => x.Date == currDate))
                {
                    number++;
                }

            }

        }

        Console.WriteLine("The number of working days till {0} are {1}", givenDate.Date, number);

    }
}