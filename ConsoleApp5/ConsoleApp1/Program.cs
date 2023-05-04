// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography.X509Certificates;

class Program


{

        static void Main(String[] args)

    {     
          double x = 7.7; // Example Value
          double y = 5.3; // Example Value
          var pi = Math.PI;


         // -6*x^3+5*x^2-10*x+15
           double result1 = -6 * Math.Pow(x,3) + 5 * Math.Pow(x, 2) - 10 * x - 15;

        // abs(x)*sin(x)
          double result2 = Math.Abs(x);

        // 2*pi*x
          double result3 = 2 * pi * x;

        // max(x, y)
        double result4 = Math.Max(x, y);

        Console.WriteLine("Result of the first math func:" + result1);    
        Console.WriteLine("Result of the second math func:" + result2);
        Console.WriteLine("Result of the third math func:" + result3);
        Console.WriteLine("Result of the third math func:" + result4);


        DateTime now = DateTime.Now;    // Create object DateTime
        int dayOfYear = now.DayOfYear;  // Get class DayOfYear of object DateTime
        int restdaysofYear = 366 - dayOfYear;

        Console.WriteLine("Today is:" + now);

        Console.WriteLine("Today's day number of Calendar Year is:" + dayOfYear);

        Console.WriteLine("Untill the end of the year have:" + restdaysofYear);
        






    }
}
