using ChalengeApp;

Console.WriteLine("Zadanie Domowe Dzien 10 ");
Console.WriteLine(" ");

var employee = new Employee("Anna", "Stelmach");  //
employee.AddGrade(2000);
employee.AddGrade("Monika");
employee.AddGrade(4);
employee.AddGrade(8.5F);
employee.AddGrade(7);

var statistics = employee.GetStatistics();

Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average:N2}");