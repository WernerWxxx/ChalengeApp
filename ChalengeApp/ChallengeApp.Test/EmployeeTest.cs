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

            employee.AddGrade(2);
            employee.AddGrade(7);
            employee.AddGrade(4);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(7, statistics.Max);

        }


        [Test]  //2
        public void MinPointsTest()
        {
            // arrange
            var employee = new Employee("Anna", "Stelmach");
            employee.AddGrade(2);
            employee.AddGrade(7);
            employee.AddGrade(4);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(2, statistics.Min);

        }

        [Test]  // 3
        public void AveragePointsTest()
        {
            // arrange
            var employee = new Employee("Anna", "Stelmach");

            employee.AddGrade(2);
            employee.AddGrade(7);
            employee.AddGrade(4);

            // act
            var statistics = employee.GetStatistics();

            // assert
            //Assert.AreEqual(6.67, statistics.Average, 0.01);
            Assert.AreEqual(Math.Round(4.33, 2), Math.Round(statistics.Average, 2));

        }

        //   [Test]  // 4
        //    public void FalshPointsTest()
        //{
        // arrange
        //    var employee = new Employee("Anna", "Stelmach");

        //    employee.AddGrade(2);
        //    employee.AddGrade(7);
        //    employee.AddGrade(5);

        // act
        //    var statistics = employee.GetStatistics();

        //assert
        //    Assert.AreEqual(6.67, statistics.Average, 0.01);
        //   Assert.AreEqual(Math.Round(4.33, 2), Math.Round(statistics.Average, 2));

        // }

    }

}
