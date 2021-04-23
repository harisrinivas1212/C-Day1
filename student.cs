using System.IO;
using System;

class Student
{
    public int RollNumber { get; set; }
    
    public string Name { get; set; }
    
    public string Gender { get; set; }
    
    static void Main()
    {
        Student student = new Student();
        student.RollNumber = 1;
        student.Name = "Hari Srinivas";
        student.Gender = "MAle";
        Console.WriteLine(student.RollNUmber+"\t"+ student.Name+"\t" + student.Gender);
        Console.ReadLine();
        
    }
    
    
}