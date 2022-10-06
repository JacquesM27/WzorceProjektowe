// See https://aka.ms/new-console-template for more information
using Composite2;

Console.WriteLine("Hello, World!");


Pte private1 = new("John", "private", 10);
decimal salary = private1.CalculateBaseSalary();
Console.WriteLine("Salary - " + salary.ToString());

Lt lieutenant = new("Adam", "", 103);
Lt lieutenant2 = new("Michael", "", 300);

lieutenant2.Add(new Pte("Stan", "", 40));
lieutenant2.Add(new Pte("Stan", "", 40));
lieutenant2.Add(new Pte("Stan", "", 40));

Lt lieutenant3 = new("Boss", "", 4000);
lieutenant3.Add(new Pte("Jim", "", 30));
lieutenant3.Add(new Pte("Jim", "", 40));
lieutenant3.Add(new Pte("John", "", 50));

lieutenant.Add(lieutenant3);
lieutenant.Add(lieutenant2);

decimal requiredBudget = lieutenant.CalculateBaseSalary();

Console.WriteLine($"Required budget for this company - {requiredBudget}");