using System.IO;
using System;

class Program
{
    static void Main(string[] args)
    {
        int Number;
        Console.WriteLine("Enter your Age:");
        Number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Number);
        if(Number >= 60)
        {
            Console.WriteLine("You are an Senior Citizen");
        }
        else if (Number >= 18)
        {
            Console.WriteLine("You are Eligible for Vote");
        }
        else
        {
            Console.WriteLine("You are Not Eligible for Vote");
        }
        Console.ReadLine();
        
    }   
}