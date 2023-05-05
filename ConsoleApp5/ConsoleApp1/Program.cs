// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography.X509Certificates;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two integer values:");

        int x = 0, y = 0, sum = 0;
        if (!int.TryParse(Console.ReadLine(), out x) || !int.TryParse(Console.ReadLine(), out y))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        if (X == Y)
        {
            sum = X; // if X and Y are equal, sum is one of them
        }
        else if (X < Y)
        {
            for (int i = X + 1; i < Y; i++) // loop through all integers between X and Y
            {
                sum += i; // add each integer to the sum
            }
        }
        else // if X > Y
        {
            for (int i = Y + 1; i < X; i++) // loop through all integers between Y and X
            {
                sum += i; // add each integer to the sum
            }
        }

        Console.WriteLine("The sum of all integers between {0} and {1} is {2}.", X, Y, sum);
    }
}