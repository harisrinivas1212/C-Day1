using System.IO;
using System;
public enum Salutation
{
    Mr = 0,
    Ms = 1,
    Mrs = 2,
    Dr = 3,
}

class Student
{

    static void Main()
    {
        Salutation salutation;
        string name;
        Console.WriteLine("Enter salutation:");
        salutation = (Salutation)Enum.Parse(typeof(Salutation), Console.ReadLine());
        Console.WriteLine("Enter Your NAme:");
        name = Console.ReadLine();
        Console.Write("\n Your Name is : {0}",salutation.ToString());
        Console.Write("." + name);
        Console.ReadLine();
        
    }
    
    
}