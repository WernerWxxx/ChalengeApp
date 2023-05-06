using System.Reflection;
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
        //  maxResult = employee1.Result;
        employeeWithMaxResult = employee;
    }


}

Console.WriteLine("Najlepszy pracownik to: ", employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname);
Console.WriteLine(" Ktory uzyskal wynik: ", employeeWithMaxResult.Result + " Punktow ");
Console.WriteLine("Który ma: ", employeeWithMaxResult.Age, " Age ");

class Employee
{
    public List<int> score = new List<int>();


    public Employee(string Name, string Surname, int Age)
    {


        this.Name = Name;
        this.Surname = Surname;
        this.Age = Age;
        //this.Result = Result;
    }
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public int Age { get; private set; }
    public int Result
    {
        get
        {
            return this.score.Sum();
        }
    }
    public void AddScore(int score)
    {
        this.score.Add(score);
    }
}
