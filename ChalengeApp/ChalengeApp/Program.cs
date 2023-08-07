using ChalengeApp;

Console.WriteLine("Zadanie Domowe Dzien 16 ");
Console.WriteLine(" ");
Console.WriteLine("Witam w Programie do oceny Pracowników ");
Console.WriteLine("====================================================== ");
Console.WriteLine(" ");
Console.WriteLine(" ");


var employee = new EmployeeInFile("Anna", "Stelmach", 33);

employee.AddGrade(0.2f);
employee.AddGrade(10.2f);
employee.AddGrade(25.2f);
employee.AddGrade('D');
employee.AddGrade("6-");

Console.WriteLine("Pracownik : " + employee.Name + " " + employee.Surname);
Console.WriteLine(" ma Lat: " + employee.Age);
//Console.WriteLine("Oznaczenie Płci M - Mężczyzna, K - Kobieta : " + employee.Gender);//
Console.WriteLine(" ");

Statistics statistics = employee.GetStatistics();

Console.WriteLine(statistics.Min);
Console.WriteLine(statistics.Max);
Console.WriteLine(statistics.Average);
Console.WriteLine(statistics.AverageLetter);

///////
//Console.WriteLine($"Average: {statistics.Average}");
//Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
//Console.WriteLine($"Min: {statistics.Min}");
//Console.WriteLine($"Max: {statistics.Max}");


//var statistics = employee.GetStatistics();
//Console.WriteLine(statistics.Min);
//Console.WriteLine(statistics.Max);
//Console.WriteLine(statistics.Average);