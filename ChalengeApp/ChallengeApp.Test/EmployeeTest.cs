using ChalengeApp;
//{
namespace ChallengeApp.Test
{
    public class EmployeeTest//
    {

        [Test]  //1
        public void MaxPointsTest()
        {
            // arrange
            var employee = new Employee();

            employee.AddGrade(90);

            // act
            var statistics = employee.Statistics;

            // assert
            Assert.AreEqual(90, statistics.Max);

        }


        [Test]  //2
        public void MinPointsTest()
        {
            // arrange
            var employee = new Employee();

            employee.AddGrade(20);

            // act
            var statistics = employee.Statistics;

            // assert
            Assert.AreEqual(20, statistics.Min);

        }

        [Test]  // 3
        public void AverageLetterPointsTest()
        {
            // arrange
            var employee = new Employee();
            employee.AddGrade(90);
            employee.AddGrade(20);

            // act
            var statistics = employee.Statistics;

            // assert
            Assert.AreEqual('C', statistics.AverageLetter);
        }

        [Test]  // 4
        public void AveragePointsTest()
        {
            // arrange
            var employee = new Employee();
            employee.AddGrade(90);
            employee.AddGrade(20);

            // act
            var statistics = employee.Statistics;

            // assert
            Assert.AreEqual(55, statistics.Average);
        }
    }
}
