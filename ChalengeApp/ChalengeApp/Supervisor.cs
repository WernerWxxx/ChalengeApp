namespace ChalengeApp
{
    public class Supervisor : Employee//, IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname, int age, char gender)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Gender = gender;
        }
        public string Name { get; private set; }//
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public char Gender { get; private set; }

        public void AddGrade(string gradeAsString)
        {

            switch (gradeAsString)
            {
                case "6":
                    AddGrade(100);
                    break;
                case "-6":
                case "6-":
                    AddGrade(95);
                    break;
                case "+5":
                case "5+":
                    AddGrade(85);
                    break;
                case "5":
                    AddGrade(80);
                    break;
                case "-5":
                case "5-":
                    AddGrade(75);
                    break;
                case "+4":
                case "4+":
                    AddGrade(65);
                    break;
                case "4":
                    AddGrade(60);
                    break;
                case "-4":
                case "4-":
                    AddGrade(55);
                    break;
                case "+3":
                case "3+":
                    AddGrade(45);
                    break;
                case "3":
                    AddGrade(40);
                    break;
                case "-3":
                case "3-":
                    AddGrade(35);
                    break;
                case "+2":
                case "2+":
                    AddGrade(25);
                    break;
                case "2":
                    AddGrade(20);
                    break;
                case "-2":
                case "2-":
                    AddGrade(15);
                    break;
                case "+1":
                case "1+":
                    AddGrade(5);
                    break;
                case "1":
                    AddGrade(0);
                    break;
                default:
                    throw new Exception("Give the number from the range of 1 to 6");
            }
        }
    }
}
