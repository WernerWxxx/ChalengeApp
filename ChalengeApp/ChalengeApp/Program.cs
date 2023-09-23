using ChalengeApp;

Console.WriteLine("Zadanie Domowe Dzien 17 ");
Console.WriteLine(" ");
Console.WriteLine("Witam w Programie do oceny Pracowników ");
Console.WriteLine("Zostaje wyświetlana informacja że została dodana ocena ");
Console.WriteLine("====================================================== ");
Console.WriteLine(" ");
Console.WriteLine(" ");

var employee = new EmployeeInMemory("Anna", "Stelmach");

employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

employee.AddGrade(0.2f);
employee.AddGrade(10.2f);
employee.AddGrade(25.2f);
employee.AddGrade('D');
employee.AddGrade("6-");

Console.WriteLine("Pracownik : " + employee.Name + " " + employee.Surname);
                                      //Console.WriteLine(" ma Lat: " + employee.Age);
Console.WriteLine(" ");

//while (true)
//{
  //  Console.WriteLine(" Podaj kolejną ocenę pracownika: ");
   // var input  = Console.ReadLine();
    //if (input == "q")
    //{
      //  break;
    //}

   // try
    //{
      //  employee.AddGrade(input);
    //}
    //catch (Exception e)
    //{
      //  Console.WriteLine($"Exception catched: {e.Message}" );
    //}
//}

Statistics statistics = employee.GetStatistics();

Console.WriteLine(statistics.Min);
Console.WriteLine(statistics.Max);
Console.WriteLine(statistics.Average);
Console.WriteLine(statistics.AverageLetter);