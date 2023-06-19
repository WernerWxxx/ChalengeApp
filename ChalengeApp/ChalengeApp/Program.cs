using ChalengeApp;

Console.WriteLine("Zadanie Domowe Dzien 13 ");
Console.WriteLine(" ");
Console.WriteLine("Witam w Programie do oceny Pracowników ");
Console.WriteLine("====================================================== ");
Console.WriteLine(" ");
Console.WriteLine("Jeśli chcesz wyjść z Programu naciśnij Litere - q ");
Console.WriteLine(" ");

var employee = new Employee();


while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");