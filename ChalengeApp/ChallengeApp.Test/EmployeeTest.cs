using ChalengeApp;

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
            employee.AddGrade(4);
            employee.AddGrade(8.5F);
            employee.AddGrade(7);

                        // act
                        var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(8.5, statistics.Max);

        }


        [Test]  //2
        public void MinPointsTest()
        {
            // arrange
            var employee = new Employee("Anna", "Stelmach");
            employee.AddGrade(2000);
            employee.AddGrade("Monika");
            employee.AddGrade(4);
            employee.AddGrade(8.5F);
            employee.AddGrade(7);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(4, statistics.Min);

        }

        [Test]  // 3
        public void AveragePointsTest()
        {
            // arrange
            var employee = new Employee("Anna", "Stelmach");
            employee.AddGrade(2000);
            employee.AddGrade("Monika");
            employee.AddGrade(4);
            employee.AddGrade(8.5F);
            employee.AddGrade(7);

            // act
            var statistics = employee.GetStatistics();

            // assert
            //Assert.AreEqual(6.67, statistics.Average, 0.01);
            Assert.AreEqual(Math.Round(6.5, 2), Math.Round(statistics.Average, 2));

        }

    }

}
