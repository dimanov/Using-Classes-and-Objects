/*
 * Problem 4. Triangle surface
 * Write methods that calculate the surface of a triangle by given:
 * Side and an altitude to it;
 * Three sides;
 * Two sides and an angle between them;
 * Use System.Math.
 */

using System;
using System.Globalization;
using System.Threading;

class TriangleSurface
{
    static void Main()
    {
        //Use . as a decimal separator
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("This program calculates the surface of a triangle.");
        Console.WriteLine("Please choose a method:");
        Console.WriteLine("1. Side and an altitude to it");
        Console.WriteLine("2. Three sides");
        Console.WriteLine("3. Two sides and an angle between them");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: CalculateSurface1(); break;
            case 2: CalculateSurface2(); break;
            case 3: CalculateSurface3(); break;
            default: Console.WriteLine("Not a valid choice"); break;
        }
    }

    private static void CalculateSurface1()
    {
        Console.Write("Please enter a side a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter an altitude to it h= ");
        double h = double.Parse(Console.ReadLine());

        double surface = (a * h) / 2;

        Console.WriteLine("The surface of the triangle is: {0}", surface);
    }

    private static void CalculateSurface2()
    {
        Console.Write("Please enter side a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter side b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter side c= ");
        double c = double.Parse(Console.ReadLine());

        double p = (a + b + c) / 2;
        double surface = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        Console.WriteLine("The surface of the triangle is: {0:F2}", surface);
    }


    private static void CalculateSurface3()
    {
        Console.Write("Please enter side a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter side b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter the angle between a and b in degrees = ");
        double degC = double.Parse(Console.ReadLine());

        double radC = degC * Math.PI / 180;

        double surface = a * b * Math.Sin(radC) / 2;

        Console.WriteLine("The surface of the triangle is: {0:F2}", surface);
    }

}