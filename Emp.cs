using System.IO;
using System;
public struct Employee
{
   public int EmployeeId;
   public string EmployeeName;
}

class emp
{

    static void Main()
    {
        Employee employee;
        employee.EmployeeId = 101;
        employee.EmployeeName = "hari";
        Console.Write(employee.EmployeeId+"\t"+ employee.EmployeeName);
        Console.ReadLine();
        
    }
    
    
}