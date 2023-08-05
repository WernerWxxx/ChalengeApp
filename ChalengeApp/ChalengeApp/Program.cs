using ChalengeApp;

Console.WriteLine("Zadanie Domowe Dzien 16 ");
Console.WriteLine(" ");
Console.WriteLine("Witam w Programie do oceny Pracowników ");
Console.WriteLine("====================================================== ");
Console.WriteLine(" ");
//Console.WriteLine("Jeśli chcesz wyjść z Programu naciśnij Litere - q ");
Console.WriteLine(" ");


var employee = new EmployeeInFile("Anna", "Stelmach", 33);

//var EmployeeInMemory = new EmployeeInMemory()
//var Employee = new EmployeeInFile();


employee.AddGrade(0.2f);
employee.AddGrade(10.2f);
employee.AddGrade(25.2f);
employee.AddGrade('D');
employee.AddGrade("6-");

//var statistics = employee.GetStatistics();
//Console.WriteLine(statistics.Min);
//Console.WriteLine(statistics.Max);
//Console.WriteLine(statistics.Average);
//
//Console.WriteLine(statistics.Average);
//Console.WriteLine(statistics.AverageLetter);
//Console.WriteLine(statistics.Min);
//Console.WriteLine(statistics.Max);
//
//Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
//Console.WriteLine($"Min: {statistics.Min}");
//Console.WriteLine($"Max: {statistics.Max}");
//var statistics = employee.CountGetStatistics();
//var statistics = employee.employeeInFile();

//List <employee employee = new List<employee>()
//{
 // employee
//};
Console.WriteLine("Pracownik : " + employee.Name + " " + employee.Surname);
Console.WriteLine(" ma Lat: " + employee.Age);
//Console.WriteLine("Oznaczenie Płci M - Mężczyzna, K - Kobieta : " + employee.Gender);//



//while (true)
//{
//  Console.WriteLine("Podaj kolejną ocenę pracownika: ");
//var input = Console.ReadLine();
// if (input == "q")
//{
//  break;
//}

//else if (input.Length == 1)
//{
//  if (char.IsLetter(input[0]))
//{
//  char character = input[0];

//try
//{
//  employee.AddGrade(character);
//}
//catch (Exception e)
//{
//  Console.WriteLine($"Exception catched: {e.Message}");
//}
//}
// else
///{
// try
//{
//  employee.AddGrade(input);
//}
//catch (Exception e)
//{
//  Console.WriteLine($"Exception catched: {e.Message}");
//}
//}
// }
//else
//{
//  try
// {
//  employee.AddGrade(input);
//}
//catch (Exception e)
//{
//    Console.WriteLine($"Exception catched: {e.Message}");
//  }
//}
//}
//List <employee employee = new List<employee>()
//{
//List <employee employee = new List<employee>()
//{
//employee
//};
//var statistics = employee.GetStatistics();
Statistics statistics = employee.GetStatistics();  //// - Powiazane z Wpisem Kodu 
//// - w Pliku EmployeeBase.cs
//public static Statistics CountStatistics(List<float> grades)

//internal Statistics CountStatistics()
//{
//  throw new NotImplementedException();
//}
//// - Powiazane z Wpisem Kodu 
//// - w Pliku EmployeeBase.cs
//var ststistics = GetStatistics(employee);
//var statistics = employee.employeeInFile();

Console.WriteLine(statistics.Average);
Console.WriteLine(statistics.AverageLetter);
Console.WriteLine(statistics.Min);
Console.WriteLine(statistics.Max);
///////
//Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
//Console.WriteLine($"Min: {statistics.Min}");
//Console.WriteLine($"Max: {statistics.Max}");

//var statistics = employee.GetStatistics();
//Console.WriteLine(statistics.Min);
//Console.WriteLine(statistics.Max);
//Console.WriteLine(statistics.Average);