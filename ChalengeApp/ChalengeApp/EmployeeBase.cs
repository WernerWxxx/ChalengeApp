namespace ChalengeApp
{

    // - Nowy Plik w Kodzie Programu  // --> 
    // Wyjasnie Działanie Kodu w Lekcji 1 i 2 Dniu 16 - WAŻNE
    //public class EmployeeInMemory : EmployeeBase//, IEmployee
    public abstract class EmployeeBase : IEmployee
    {

        private List<float> grades = new List<float>();

        //public EmployeeBase(string name, string surname, int age, char gender)
        public EmployeeBase(string name, string surname, int age)
        //: this
        {
            this.Name = name;//
            this.Surname = surname;
            this.Age = age;
            //this.Gender = gender;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        // public char Gender { get; private set; }

        //public void AddGrade(float grade)
        //{
          //  this.grades.Add(grade);
        //}


        public abstract void AddGrade(float grade);
        //{
        //  throw new NotImplementedException();

        // }

        public abstract void AddGrade(double grade);
        //{
        //  throw new NotImplementedException();
        //}

        public abstract void AddGrade(long grade);
        //{
        //  throw new NotImplementedException();
        //}

        public abstract void AddGrade(int grade);
        //{
        //   throw new NotImplementedException();
        //}

        public abstract void AddGrade(char grade);
        //{
        //   throw new NotImplementedException();
        //}

        public abstract void AddGrade(string grade);
        //{
        //  throw new NotImplementedException();
        //}

        // ------------ > public abstract Statistics GetStatistics();
        //{
        //vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
        //internal Statistics CountStatistics()
        //{
        //  throw new NotImplementedException();
        //}

        //----------- > public abstract Statistics CountStatistics(); // { get; }
        //{
        //throw new NotImplementedException();
        //}
        //internal object CountGetStatistics()

        //internal object CountGetStatistics { get; }

        //public abstract Statistics GetStatistics { get; }  //();

        //public override Statistics CountStatistics => throw new NotImplementedException();

        public abstract Statistics GetStatistics();

        //public abstract Statistics CountStatistics();

        //public abstract Statistics CountStatistics { get; }  //();

        //public abstract Statistics Getstatistics(); // { get;  }
        //internal object Statistics statistics { get;  }
        //{
        //  throw new NotImplementedException();
        //}

    }
}
