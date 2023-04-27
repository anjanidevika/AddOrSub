//program that adds when a<b and subtracts when a>b
using System;
public class Program
{
    static void addorsub(int a, int b)
    {
        if (a > b)
            Console.WriteLine("the numbers are subtracted:" + (a - b));
        else
            Console.WriteLine("the numbers are added:" + (a + b));
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a number");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter another number");
        int b = Convert.ToInt32(Console.ReadLine());
        addorsub(a, b);
    }
}
