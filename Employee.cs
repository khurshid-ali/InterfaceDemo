using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceDemo;

/// <summary>
/// base class
/// super class 
/// paretnt class
/// </summary>
public class Employee
{

    public string Name { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }

    public virtual decimal MonthlyCost()
    {
        return Salary / 12;
    }
}