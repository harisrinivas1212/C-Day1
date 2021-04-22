using System.IO;
using System;

class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("Enter num. \n 1.Addition \n 2.Sub \n 3.Mul ");
      int num = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(num);
      switch (num)
      {
        case 1:
            Console.WriteLine("Addition");
            break;
        case 2:
            Console.WriteLine("Sub");
            break;
        case 3:
            Console.WriteLine("Mul");
            break;
        default:
            Console.WriteLine("Nothing");
            break;
      }
        Console.ReadLine();
        
    }   
}