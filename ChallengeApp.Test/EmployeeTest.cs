using ChalengeApp;

namespace ChallengeApp.Test
{
    public class Test
    {
        [Test]  //1
        public void MaxPointsTest()
        {

            // arrange
            var employee = new Employee("Adam", "Nowicki");

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
            var employee = new Employee("Adam", "Nowicki");
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
            var employee = new Employee("Adam", "Nowicki");

            employee.AddGrade(2);
            employee.AddGrade(7);
            employee.AddGrade(4);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(Math.Round(4.33, 2), Math.Round(statistics.Average, 2));
            //Assert.AreEqual(6.67, statistics.Average, 0.01);

        }

        //  [Test]  // 4  - Błąd w Kodzie Programu
        //public void AverageBladPointsTest()
        //{
        // arrange
        //    var employee = new Employee("Adam", "Nowicki");

        //    employee.AddGrade(1);
        //    employee.AddGrade(7);
        //    employee.AddGrade(3);

        // act
        //   var statistics = employee.GetStatistics();

        // assert
        //   Assert.AreEqual(Math.Round(4.33, 2), Math.Round(statistics.Average, 2));


        // }

    }
}
