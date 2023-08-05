using System.Diagnostics;

namespace ChalengeApp
{
    // - Nowy Plik w Kodzie Programu  // --> 
    // Wyjasnie Działanie Kodu w Lekcji 2 Dniu 16 - WAŻNE
    public class EmployeeInMemory : EmployeeBase//, IEmployee
    {

        private List<float> grades = new List<float>();


        public EmployeeInMemory(string name, string surname, int age)
           //public EmployeeInMemory(string name, string surname, int age, char gender)
           : base(name, surname, age)
        {

        }

        //public override Statistics GetStatistics { get; }
        //{
          //throw new NotImplementedException();
        //}

        //  - Nowy Wpis w Kodzie Programu w Lekcji 3 Dniu 16
        //-----------------------------------------
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                //writer.WriteLine(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }
        //---------------------------------------

        //public override void AddGrade(float grade)
        //{
          //this.grades.Add(grade);
             //writer.WriteLine(grade);

        //}





        public override void AddGrade(double grade)
        {
            //throw new NotImplementedException();
            //grade = Math.Round(grade, 2);
            //float result = (float)grade;
            //this.AddGrade(result);

            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
            //float result = grade;
        }

        public override void AddGrade(long grade)
        {
            //throw new NotImplementedException();
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
            //float result = grade;
            //this.AddGrade(result);

            //this.AddGrade((float)grade);
        }

        public override void AddGrade(int grade)
        {
            //throw new NotImplementedException();
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
            //float result = grade;
            //this.AddGrade(result);
        }

        public override void AddGrade(char grade)
        {
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

        public override void AddGrade(string grade)
        {
        //    if (float.TryParse(grade, out float result))
          //  {
            //    this.AddGrade(result);
            //}
            //else
            //{
                throw new Exception("String is not float");
            //}
        }
        //----------------------------------------------------------
        //public override Statistics GetStatistics()
        //{
        //  var gradesFromFile = this.ReadGradesFromFile();
        //var result = this.CountStatistics(gradesFromFile);
        //return result;
        //}

        //rivate List<float> ReadGradesFromFile()
         //{
         //  var grades = new List<float>();
         // if (File.Exist($"{fileName}"))
         //{
         //  using (var reader = File.OpenText($"{fileName}"))
         //{
         //  var line = reader.ReadLine();
         //while (line != null)
         //{
         //  var number = float.Parse(line);
         //grades.Add(number);
         //line = reader.ReadLine();
         //}
         //}


        //statistics.Average / this.grades.Count;



        //}
        //return statistics;
        //}
        //--------------------------------------------------------------

        //internal object CountStatistics()
        //{
        // throw new NotImplementedException();
        //}

        //public abstract Statistics CountGetStatistics();
        //{
        //throw new NotImplementedException();
        //}
        //public override Statistics Statistics => throw new NotImplementedException();

        //wwwwwwwwwwwwwwwwww,,,,,,.....vvvvvvvvvvvvvvvvvvvvv wpis--------------------
        //----------->public override Statistics GetStatistics => throw new NotImplementedException();
        //public override Statistics GetStatistics => throw new NotImplementedException();

        public override Statistics GetStatistics()
        {
           throw new NotImplementedException();
        }

        //public override Statistics CountStatistics()
        //{
          //  throw new NotImplementedException();
        //}

        //Statistics CountStatistics(List<float> grades)
        //public override Statistics CountStatistics()
        //{
        //  throw new NotImplementedException();
        //}

        //public new override Statistics Statistics
        //{
        //  throw new NotImplementedException();
        //}

    }
}