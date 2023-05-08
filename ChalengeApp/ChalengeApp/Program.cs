using ChalengeApp;

Console.WriteLine("Zadanie Domowe Dzien 6 ");
Console.WriteLine(" ");

Employee employee1 = new Employee("Adam", "Nowicki", 22);
Employee employee2 = new Employee("Monika", "Druk", 28);
Employee employee3 = new Employee("Zuzia", "Pika", 34);

employee1.AddScore(5);
employee1.AddScore(9);
employee1.AddScore(9);
employee1.AddScore(9);
employee1.AddScore(4);

employee2.AddScore(2);
employee2.AddScore(5);
employee2.AddScore(9);
employee2.AddScore(8);
employee2.AddScore(8);

employee3.AddScore(6);
employee3.AddScore(1);
employee3.AddScore(5);
employee3.AddScore(6);
employee3.AddScore(6);

int age1 = 10;
int age2 = 3;

List<Employee> employees = new List<Employee>()
{
     employee1, employee2,employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine("Najlepszy pracownik to: " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname);
Console.WriteLine(" Ktory uzyskal wynik: " + employeeWithMaxResult.Result + " Points ");
Console.WriteLine("Który ma: " + employeeWithMaxResult.Age + " Age ");


