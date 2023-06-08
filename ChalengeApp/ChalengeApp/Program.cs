using ChalengeApp;

Console.WriteLine("Zadanie Domowe Dzien 11 ");
Console.WriteLine(" ");

var employee = new Employee("Anna", "Stelmach");  //
employee.AddGrade(2000);
employee.AddGrade("Monika");
employee.AddGrade("4000");
employee.AddGrade(7);
employee.AddGrade(8);
employee.AddGrade(9.5f);

var statistics = employee.GetStatistics();

var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();

Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine(" ");
Console.WriteLine("Foreach");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine(" ");
Console.WriteLine("For");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine(" ");
Console.WriteLine("DoWhile");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine(" ");
Console.WriteLine("While");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");
Console.WriteLine($"Average: {statistics4.Average:N2}");

//(out statistics);
//void SetSth(out Statistics statistics);
//{
//  statistics = new Statistics;
//}
