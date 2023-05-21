using ChalengeApp;

Console.WriteLine("Zadanie Domowe Dzien 9 ");
Console.WriteLine(" ");

var employee = new Employee("Adam", "Nowicki");  //
employee.AddGrade(2);
employee.AddGrade(7);
employee.AddGrade(4);

var statistics = employee.GetStatistics();

Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average:N2}");