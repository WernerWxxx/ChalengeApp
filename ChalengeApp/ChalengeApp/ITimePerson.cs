using static ChalengeApp.TimePersonBase;

namespace ChalengeApp
{
    public interface ITimePerson
    {
        string Name { get; }

        string Surname { get; }

        //int Age { get; }

        void AddGrade(float grade);

        void AddGrade(double grade);

        void AddGrade(long grade);

        void AddGrade(int grade);

        void AddGrade(string grade);

        event GradeAddedDelegate GradeAdded;
        Statistics GetStatistics();

    }
}