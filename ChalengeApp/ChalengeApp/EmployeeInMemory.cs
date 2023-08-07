using System.Diagnostics;

namespace ChalengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {

        private List<float> grades = new List<float>();

        //public EmployeeInMemory(string name, string surname, int age, char gender)
        public EmployeeInMemory(string name, string surname, int age)
           : base(name, surname, age)
        {

        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                //this.grades.Add(grade);
                //writer.WriteLine(grade);

                this.grades.Add(grade);
                //writer.WriteLine(grade);
                Console.WriteLine($"Successfully added: {grade}"); // - Wyswietla liczby przypisane
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public override void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(long grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(char grade)
        {
            //throw new NotImplementedException();
            //float gradeAsFloat = (float)grade;
            //this.AddGrade(gradeAsFloat);
            // throw new NotImplementedException();
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Type figure or letter between A - E");
            }

        }

        public override void AddGrade(string grade)
        {
            //throw new NotImplementedException();
            switch (grade)
            {
                case "6":
                    this.AddGrade(100);
                    break;
                case "6-":
                case "-6":
                    this.AddGrade(95);
                    break;
                case "5":
                    this.AddGrade(80);
                    break;
                case "5+":
                case "+5":
                    this.AddGrade(85);
                    break;
                case "5-":
                case "-5":
                    this.AddGrade(75);
                    break;
                case "4":
                    this.AddGrade(60);
                    break;
                case "4+":
                case "+4":
                    this.AddGrade(65);
                    break;
                case "4-":
                case "-4":
                    this.AddGrade(55);
                    break;
                case "3":
                    this.AddGrade(40);
                    break;
                case "3+":
                case "+3":
                    this.AddGrade(45);
                    break;
                case "3-":
                case "-3":
                    this.AddGrade(35);
                    break;
                case "2":
                    this.AddGrade(20);
                    break;
                case "2+":
                case "+2":
                    this.AddGrade(25);
                    break;
                case "2-":
                case "-2":
                    this.AddGrade(15);
                    break;
                case "1":
                    this.AddGrade(0);
                    break;
                case "1+":
                case "+1":
                    this.AddGrade(5);
                    break;
                default:
                    throw new Exception("Give the number from the range of 1 to 6");
            }
        }

        public override Statistics GetStatistics()
        {
            //throw new NotImplementedException();
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;


            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;

                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;

                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;

                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;

                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}