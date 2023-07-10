using ChalengeApp;

Console.WriteLine("Zadanie Domowe Dzien 15 ");
Console.WriteLine(" ");
Console.WriteLine("Witam w Programie do oceny Pracowników ");
Console.WriteLine("====================================================== ");
Console.WriteLine(" ");
Console.WriteLine("Jeśli chcesz wyjść z Programu naciśnij Litere - q ");
Console.WriteLine(" ");


var employee = new Employee();
             
var supervisor = new Supervisor("Anna", "Stelmach", 33, 'K');


List <Supervisor> supervisors = new List<Supervisor>()
{
     supervisor
};
Console.WriteLine("Pracownik : " + supervisor.Name + " " + supervisor.Surname);
Console.WriteLine(" ma Lat: " + supervisor.Age);
Console.WriteLine("Oznaczenie Płci M - Mężczyzna, K - Kobieta : " + supervisor.Gender);

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    else if (input.Length == 1)
    {
        if (char.IsLetter(input[0]))
        {
            char character = input[0];

            try
            {
                supervisor.AddGrade(character);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception catched: {e.Message}");
            }
        }
        else
        {
            try
            {
                supervisor.AddGrade(input);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception catched: {e.Message}");
            }
        }
    }
    else
    {
        try
        {
            supervisor.AddGrade(input);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }
    }
}

var statistics = supervisor.GetStatistics();

Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");