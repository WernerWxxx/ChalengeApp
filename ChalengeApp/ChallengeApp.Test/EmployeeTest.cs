using ChalengeApp;

namespace ChallengeApp.Test
{
    public class Test
    {
        [Test]  //1
        public void TypeTest()
        {

            //arrange
            var employee1 = GetEmployee("Adam", "Nowak", 37);
            var employee2 = GetEmployee("Ania", "Mosa", 47);


            //act


            // assert
            Assert.AreNotEqual(employee1, employee2);

        }

        //  [Test]  //2
        public void SumeSurnameTest()
        {

            //arrange
            var employee1 = GetEmployee("Adam", "Nowicki", 21);
            var employee2 = GetEmployee("Monika", "Pocik", 33);



            //act


            // assert
            Assert.AreNotEqual(employee1.Age, employee2.Age);

        }

        [Test]  // 3
        public void SumeWeigthTest()
        {

            //arrange
            double employeex1 = 12.3;
            double employeex2 = 12.3;
            


            //act


            // assert
            Assert.AreEqual(employeex1, employeex2);

        }

        [Test]   // 4
        public void TheIntTest()
        {

            //arrange
            int age1 = 25;
            int age2 = 25;

            //act


            // assert
            Assert.AreEqual(age1, age2);
        }

            [Test]   // 5
            public void TheFloatTest()
            {

                //arrange
                float f1 = 3.5f;
                float f2 = 3.5f;
                //float ffff1 = 134.45E-2f;
                //float ffff2 = 134.45E-2f;

                //act


                // assert
                Assert.AreEqual(f1, f2);
            }

        

        private Employee GetEmployee(string Name, string Surname, int Age)
        {
            return new Employee(Name, Surname, Age);
        }
    }

}
