using System.IO;
using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[5];
        int sum = 0;
        Console.WriteLine("Enter num");
        for(int i=0; i<arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(arr[i]);
        }
        
        for(int i =0; i<arr.Length; i++)
        {
            sum = sum + arr[i];
        }
        Console.WriteLine("sum of 5 num is " + sum);
        Console.ReadLine();
        
    }   
}