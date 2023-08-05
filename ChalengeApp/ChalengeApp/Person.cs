namespace ChalengeApp
{
    public abstract class Person
    {
        public Person(string name, string surname, string age, string gender)
        {
            this.Name = name;//
            this.Surname = surname;
            this.Age = age;
            // this.Gender = gender;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Age { get; private set; }
        //public string Gender { get; private set; }//
    }
}