namespace ChalengeApp
{
    public interface IEmployee//, Employee
    {
        string Name { get; }

        string Surname { get; }

        int Age { get; }//

        // char Gender { get; }


        void AddGrade(float grade);

        void AddGrade(double grade);

        void AddGrade(long grade);

        void AddGrade(int grade);

        void AddGrade(char grade);

        void AddGrade(string grade);
        //Statistics CountStatistics();

        //Statistics GetStatistics();

        //Statistics GetStatistics { get; }//
        Statistics GetStatistics();


        //Statistics CountStatistics();

        //Statistics CountStatistics(List<float> grades);


        //Statistics GetStatistics();
        ///{
           // throw new NotImplementedException();
        //}

        //Statistics Statistics { get; }
        //{
        //public override Statistics GetStatistics => throw new NotImplementedException();
        //}

       // public override Statistics CountStatistics => throw new NotImplementedException();
    }
}
