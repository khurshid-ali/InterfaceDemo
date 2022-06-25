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

List<Employee> employeeList = new List<Employee>();
employeeList.Add(heather);
employeeList.Add(adam);
employeeList.Add(carl);
employeeList.Add(brian);

var totalCost = 0.00M;

foreach (Employee emp in employeeList)
{
    totalCost += emp.MonthlyCost();
}

Console.WriteLine($"Total cost is {totalCost.ToString("c")}");