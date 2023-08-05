using System.Diagnostics;
using System.Globalization;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ChalengeApp
{
    // - Nowy Plik w Kodzie Programu  // --> 
    // Wyjasnie Działanie Kodu w Lekcji 2 Dniu 16 - WAŻNE
    public class EmployeeInFile : EmployeeBase//, IEmployee //, EmployeeInMemory
    {
        //private List<float> grades = new List<float>();

        private const string fileName = "grades.txt";

        //private List<float> grades = new List<float>();
        //private List<float> grades(string fileName);
        //private List<float> GetGradesFile(string fileName);

        //  - Nowy Wpis w Kodzie Programu w Lekcji 5 Dniu 16
        //public Statistics employeeInFile(List<float> grades)


        public EmployeeInFile(string name, string surname, int age)
           : base(name, surname, age)
        {
            //this.Name = name;//
            //this.Surname = surname;
            //this.Age = age;
            //this.Gender = gender;
        }

        //public override void AddGrade(float grade)
        //{
          //this.grades.Add(grade);
        //}

        /// /////////////////////////////////////

        // public override Statistics CountStatistics => throw new NotImplementedException();


        //---------------------------------------
        public override void AddGrade(float grade)
        {
            // NOWY WPIS KODU - ZAPIS DANYCH DO PLIKU .TXT
            //using (var writer = File.AppendText(fileName))
            //{
              //  writer.WriteLine(grade);
            //}
            //throw new NotImplementedException();
            //this.AddGrade((float)grade);
            //==================================================//
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                    Console.WriteLine($"Successfully added: {grade}");
                }
            }
            else
            {
                throw new Exception("Invalid grade value! Try again.");
            }
            //====================================================
        }
        //---------------------------------------

        public override void AddGrade(double grade)
        {
            //throw new NotImplementedException();
            //float gradeAsFloat = (float)grade;
            //this.AddGrade(gradeAsFloat);

            this.AddGrade((float)grade);
        }
        public override void AddGrade(long grade)
        {
            //throw new NotImplementedException();
            //float gradeAsFloat = (float)grade;
            //this.AddGrade(gradeAsFloat);

            this.AddGrade((float)grade);
        }

        public override void AddGrade(int grade)
        {
            //throw new NotImplementedException();
            //float gradeAsFloat = grade;
            //this.AddGrade(gradeAsFloat);

            this.AddGrade((float)grade);
        }

        public override void AddGrade(string grade)
        {
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
                   // if (float.TryParse(grade, out float result))
                    //{
                      //  this.AddGrade(result);
                    //}
                    //else if (double.TryParse(grade, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double resultDouble))
                    //{
                      //  this.AddGrade(resultDouble);
                    //}
                    //else
                    //{
                     //   throw new Exception("String is not any of the correct data types");
                    //}
                    break;
            }
            //throw new NotImplementedException();
            //-------------------------------------
            //if (float.TryParse(grade, out float result))
            //{
              //  this.AddGrade(result);
            //}
            //else
            //{
              //  throw new Exception("String is not float");
            //}
            //--------------------------------------
        }

        public override void AddGrade(char grade)
        {
            //throw new NotImplementedException();
            switch (grade)
            {
                case 'A':
                case 'a':
                    //this.GetGradesFile.Add(100);
                    //this.Addgrades.Add(100);
                    //this.grades.Add(100);
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    //this.GetGradesFile.Add(80);
                    //this.Addgrades.Add(80);
                    //this.grades.Add(80);
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    //this.GetGradesFile.Add(60);
                    //this.Addgrades.Add(60);
                    //this.grades.Add(60);
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    // this.GetGradesFile.Add(40);
                    //this.Addgrades.Add(40);
                    //this.grades.Add(40);
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    //this.GetGradesFile.Add(20);
                    //this.Addgrades.Add(20);
                    //this.grades.Add(20);
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Type figure or letter between A - E");
            }
        }

        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = CountStatistics(gradesFromFile);
            return result;
        }

        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        //sb.Append($"{line}; ");
                        line = reader.ReadLine();
                    }
                }

               //statistics.Average / this.grades.Count;
            }
            return grades;
        }

        public Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }

                statistics.Average /= grades.Count;

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

                //return statistics;
            }
            return statistics;
        }
    }
}