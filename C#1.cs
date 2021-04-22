using System.IO;
using System;

class Program
{
    static void Main(string[] args)
    {

        int firstNumber, secondNumber, result;
        Console.WriteLine("Enter num1:");
        firstNumber =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(firstNumber);
        Console.WriteLine("Enter num2:");
        secondNumber =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(secondNumber);
        result = firstNumber+secondNumber;
        Console.WriteLine("sum of two number is " +result);
        Console.ReadLine();
    }   
}