using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceDemo;

public class Vehicle : IExpensable
{

    public string Registration { get; set; }
    public decimal Rate { get; set; }

    public Vehicle(string registration, decimal rate)
    {
        Registration = registration;
        Rate = rate;
    }

    public decimal MonthlyCost()
    {
        return Rate * 30;
    }

    public decimal MonthlyExpense()
    {
        return Rate * 30;
    }
}
