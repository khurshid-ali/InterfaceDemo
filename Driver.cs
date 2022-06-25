using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceDemo;

/// <summary>
/// Child class
/// Derived Class
/// </summary>
public class Driver : Employee
{
    public decimal HourlyRate { get; set; }
    public int Hours { get; set; }

    public Driver(string name, decimal hourlyRate, int hours) : base(name, 0M)
    {
        HourlyRate = hourlyRate;
        Hours = hours;
    }


    public override decimal MonthlyCost()
    {
        return 4 * HourlyRate * Hours;
    }
}