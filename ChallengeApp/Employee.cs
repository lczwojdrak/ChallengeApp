namespace ChallengeApp
//jak to zrobić
{
    public class Employee : IEmployee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid Grade Value");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char resultChar))
            {
                this.AddGrade(resultChar);
            }
            else
            {
                throw new Exception("Float is not a value");
            }
        }
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong letter, please use A - E");
            }

        }
        public void AddGrade(double grade)
        {
            float results = (float)grade;
            this.AddGrade(results);
        }

        public void AddGrade(decimal grade, int v)
        {

            float results = (float)grade;
            this.AddGrade(results);
        }

        public void AddGrade(sbyte grade)
        {
            float results = (float)grade;
            this.AddGrade(results);
        }

        public void AddGrade(long grade)
        {
            float results = (float)grade;
            this.AddGrade(results);
        }

        public statistics GetStatistics()
        {
            var statistics = new statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}
