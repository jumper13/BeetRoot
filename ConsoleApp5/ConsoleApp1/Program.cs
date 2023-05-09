// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Teacher!");


Console.Write("Put the Number:");
int x = int.Parse(Console.ReadLine());



int FibSum(int a)  // Fibbonacci Number Counted by method cycle FOR
{
    if (a == 0) return 0;
    if (a == 1) return 1;
    int num1 = 0;
    int num2 = 1;
    int sum = 0;
    for (int i = 2; i <= a; i++)
    {
        sum = num1 + num2; //2(1)
        num1 = num2;
        num2 = sum;
    }
    return sum;
}

int result = FibSum(x);

Console.WriteLine("Fibbonacci Number Counted by method cycle FOR " + result);



int Fibonacci(int n)  // Fibbonacci Number Counted by Recursion Method
{

    if (n <= 0) return 0;
    if (n == 1) return 1;
    else
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}





Console.Write("Put the Number:");
int x1 = int.Parse(Console.ReadLine());



int result1 = Fibonacci(x1);
Console.WriteLine("Fibbonacci Number Counted by Recursion Method " + result1);


// 0, 1, 2, 3, 4, 5, 6, 7,   8,  9, 10
// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 45 