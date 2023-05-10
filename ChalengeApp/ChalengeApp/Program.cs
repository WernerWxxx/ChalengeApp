using ChalengeApp;

Console.WriteLine("Zadanie Domowe Dzien 6 ");
Console.WriteLine(" ");

Employee employee1 = new Employee("Adam", "Nowicki", 22);
Employee employee2 = new Employee("Monika", "Druk", 28);
Employee employee3 = new Employee("Zuzia", "Pika", 34);
//Employee employee4 = new Employee("Zuzia2", "Pika2");

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
double employeex1 = 12.3;
double employeex2 = 12.3;
//float f1 = 3_000.5F;
//float f2 = 3_000.5F;
//float f1 = 134.45E-2f;
//float f2 = 134.45E-2f;
float f1 = 3.5f;
float f2 = 3.5f;

//string stri1 = nameb;
//string stri2 = nameb;
//System.Double b = 12.3;
//float emp1 = 14,0;
//float emp2 = 14,2;

//double use1 = 14,777;
//double use2 = 14,99;


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


