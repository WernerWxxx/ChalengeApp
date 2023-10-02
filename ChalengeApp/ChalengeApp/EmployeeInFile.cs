namespace ChalengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname)
           : base(name, surname)
        {

        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Value is out of range 0 - 100");
            }
        }
        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                AddGrade(result);
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
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
            //this.AddGrade((float)grade);
        }

       // public override void AddGrade(string grade)
        //{
          //  switch (grade)
            //{
              //  case "6":
                //    AddGrade(100);
                  //  break;
                //case "-6":
                //case "6-":
                  //  AddGrade(95);
                    //break;
                //case "+5":
                //case "5+":
                  //  AddGrade(85);
                    //break;
                //case "5":
                  //  AddGrade(80);
                    //break;
                //case "-5":
                //case "5-":
                  //  AddGrade(75);
                    //break;
                //case "+4":
                //case "4+":
                  //  AddGrade(65);
                    //break;
                //case "4":
                  //  AddGrade(60);
                    //break;
                //case "-4":
                //case "4-":
                  //  AddGrade(55);
                    //break;
                //case "+3":
                //case "3+":
                  //  AddGrade(45);
                    //break;
                //case "3":
                  //  AddGrade(40);
                    //break;
                //case "-3":
                //case "3-":
                  //  AddGrade(35);
                    //break;
                //case "+2":
                //case "2+":
                  //  AddGrade(25);
                    //break;
                //case "2":
                  //  AddGrade(20);
                    //break;
                //case "-2":
                //case "2-":
                  //  AddGrade(15);
                    //break;
                //case "+1":
                //case "1+":
                  //  AddGrade(5);
                    //break;
                //case "1":
                  //  AddGrade(0);
                    //throw new Exception("Give the number from the range of 1 to 6");
          //  }
        //}

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    AddGrade(100);
                    //this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    AddGrade(20);
                    break;
                default:
                    throw new Exception("Type figure or letter between A - E");

            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();


            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line == string.Empty)
                            continue;
                        if (float.TryParse(line, out float lineinfloat))
                        {
                            statistics.AddGrade(lineinfloat);
                        }
                        else
                        {
                            throw new Exception("file contains invalid value");
                        }
                    }
                }
            }
            return statistics;
        }

    }
}