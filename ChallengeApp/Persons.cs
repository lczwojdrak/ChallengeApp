namespace ChallengeApp
{
    public class Person
    {
        public Person(string name, string surname, string sex, int age)
        {
            Name = name;
            Surname = surname;
            Sex = sex;
            Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Sex { get; private set; }
        public int Age { get; private set; }
    }
}

