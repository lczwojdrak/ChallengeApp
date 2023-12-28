namespace ChallengeApp
{
    public class Employee
    {
        private List<int> score = new List<int>();

        public Employee(string login)
        {
            Login = login;
        }

        public Employee(string login, string surname, int age)
        {
            this.Login = login;
            this.Surname = surname;
            this.Age = age;
        }

        public string Login { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int number)
        {
            this.score.Add(number);

        }
    }
}