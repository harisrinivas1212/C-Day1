using System.IO;
using System;

class Program
{
    static void Main(string[] args)
    {
        int Number;
        Console.Write("Enter a number:");
        Number = Convert.ToInt32(Console.ReadLine());
        if(Number < 18)
        {
            Console.Write("Not Eligible for Vote");
        }
        else 
        {
            Console.WriteLine("Eligible for Vote");
        }
        Console.ReadLine();
        
    }   
}