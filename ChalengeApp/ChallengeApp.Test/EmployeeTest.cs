using ChalengeApp;
//{
namespace ChallengeApp.Test
{
    public class EmployeeTest
    {

        [Test]  //1
        public void MaxPointsTest()
        {

            // arrange
            var employee = new Employee("Anna", "Stelmach");

            employee.AddGrade(2000);
            employee.AddGrade("Monika");
            employee.AddGrade("4000");
            employee.AddGrade(7);
            employee.AddGrade(8);
            employee.AddGrade(9.5f);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(9.5f, statistics.Max);

        }


        [Test]  //2
        public void MinPointsTest()
        {
            // arrange
            var employee = new Employee("Anna", "Stelmach");
            employee.AddGrade(2000);
            employee.AddGrade("Monika");
            employee.AddGrade("4000");
            employee.AddGrade(7);
            employee.AddGrade(8);
            employee.AddGrade(9.5f);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(7, statistics.Min);

        }

        [Test]  // 3
        public void AveragePointsTest()
        {
            // arrange
            var employee = new Employee("Anna", "Stelmach");
            employee.AddGrade(2000);
            employee.AddGrade("Monika");
            employee.AddGrade("4000");
            employee.AddGrade(7);
            employee.AddGrade(8);
            employee.AddGrade(9.5f);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(Math.Round(8.17f, 2), Math.Round(statistics.Average, 2));

        }
    }
}
