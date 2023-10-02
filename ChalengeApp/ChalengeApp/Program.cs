using ChalengeApp;

Console.WriteLine("Zadanie Domowe Dzien 18 ");
Console.WriteLine(" ");
Console.WriteLine("Witam w Programie do oceny Pracowników ");
Console.WriteLine("Zostaje wyświetlana informacja - przez delegat że została dodana ocena ");
Console.WriteLine("Cała logika Kodu Programu obliczającego Statystyki jest przeniesiona do ");
Console.WriteLine("Pliku Statistics.cs ");
Console.WriteLine("====================================================== ");
Console.WriteLine(" ");
Console.WriteLine(" ");

var employee = new EmployeeInFile("Anna", "Stelmach");
void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}
employee.GradeAdded += EmployeeGradeAdded;

//employee.AddGrade(0.4f);
 //employee.AddGrade(14.7f);
//employee.AddGrade(32.2f);
//employee.AddGrade('D');
//employee.AddGrade("6-");
//employee.AddGrade(44);

Console.WriteLine("Pracownik : " + employee.Name + " " + employee.Surname);
                                //Console.WriteLine(" ma Lat: " + employee.Age);
Console.WriteLine(" ");

while (true)
{
    Console.WriteLine(" Podaj kolejną ocenę pracownika: ");
    var input  = Console.ReadLine();
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

Statistics statistics = employee.GetStatistics();

Console.WriteLine(statistics.Min);
Console.WriteLine(statistics.Max);
Console.WriteLine(statistics.Average);
Console.WriteLine(statistics.AverageLetter);