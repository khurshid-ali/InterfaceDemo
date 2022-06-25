using InterfaceDemo;


Employee heather = new Employee("Heather Brown", 50000M);
decimal heatherCost = heather.MonthlyCost();
Console.WriteLine($"Heather's cost is {heatherCost.ToString("c")}");

Employee adam = new Employee("Adam Baker", 42000M);
decimal adamCost = adam.MonthlyCost();
Console.WriteLine($"Adam's cost is {adamCost.ToString("c")}");

Driver carl = new Driver("Carl Anderson", 22.50M, 40);
decimal carlCost = carl.MonthlyCost();
Console.WriteLine($"Carl's monthly cost {carlCost.ToString("c")}");

Employee brian = new Driver("Brian Davis", 17.25M, 25);
decimal brianCost = brian.MonthlyCost();
Console.WriteLine($"Brian's monthly cost {brianCost.ToString("c")}");

Vehicle vehicle1 = new Vehicle("B-325", 35.00M);
decimal v1Cost = vehicle1.MonthlyCost();
Console.WriteLine("{0} vehicle cost = {1}", vehicle1.Registration, v1Cost.ToString("c"));

Vehicle vehicle2 = new Vehicle("D-425", 65.00M);
decimal v2Cost = vehicle1.MonthlyCost();
Console.WriteLine("{0} vehicle cost = {1}", vehicle2.Registration, v2Cost.ToString("c"));

List<IExpensable> expenseList = new List<IExpensable>();
expenseList.Add(heather);
expenseList.Add(adam);
expenseList.Add(carl);
expenseList.Add(brian);
expenseList.Add(vehicle1);
expenseList.Add(vehicle2);

var totalExpense = 0.00M;

foreach (IExpensable item in expenseList)
{
    totalExpense += item.MonthlyExpense();
}

Console.WriteLine("Total Monthly expense {0}", totalExpense.ToString("c"));