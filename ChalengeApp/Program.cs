using ChalengeApp;

Console.WriteLine("Zadanie Domowe Dzien 9 ");
Console.WriteLine(" ");

var employee = new Employee("Adam", "Nowicki");


employee.AddGrade(2);
employee.AddGrade(7);
employee.AddGrade(4); 


var Statistics = employee.GetStatistics();

Console.WriteLine($"Min: {Statistics.Min}");
Console.WriteLine($"Max: {Statistics.Max}");
Console.WriteLine($"Average: {Statistics.Average:N2}");

