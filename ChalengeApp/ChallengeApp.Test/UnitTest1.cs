using ChalengeApp;

namespace ChallengeApp.Test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {

            //arrange
            var employee = new Employee("Adam", "Nowicki", 22);
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddScore(-3);
            employee.AddScore(-4);

            //act
            var result = employee.Result;

            // assert
            Assert.AreEqual(4, result);

        }
    }
}