namespace ChalengeApp
{
    public class Employee
    {

        public List<float> grades = new List<float>();

        //private const char sex = 'M';

        public Employee()
        {

        }

        public string Name { get; private set; }
        public string Surname { get; private set; }




        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Float is wrong - niewłaściwa wartość");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {

                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char charResult))
            {

                switch (charResult)
                {
                    case 'A':
                    case 'a':
                        this.grades.Add(100);
                        break;
                    case 'B':
                    case 'b':
                        this.grades.Add(80);
                        break;
                    case 'C':
                    case 'c':
                        this.grades.Add(60);
                        break;
                    case 'D':
                    case 'd':
                        this.grades.Add(40);
                        break;
                    case 'E':
                    case 'e':
                        this.grades.Add(20);
                        break;
                    default:
                        throw new Exception("Wrong Letter");
                }
            }
            else
            {
                throw new Exception("Type figure or letter between A - E");
            }
        }
            public void AddGrade(double grade)
        {
            grade = Math.Round(grade, 2);
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(long grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        // Przygotowanie Metody która zwróci oceny
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average = statistics.Average + grade;
            }
            statistics.Average = statistics.Average / this.grades.Count;

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