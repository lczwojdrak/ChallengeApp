namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname)
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
        }

        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    AddGrade(100);
                    break;
                case "-6":
                case "6-":
                    AddGrade(95);
                    break;
                case "5":
                    AddGrade(80);
                    break;
                case "+5":
                case "5+":
                    AddGrade(85);
                    break;
                case "-5":
                case "5-":
                    AddGrade(75);
                    break;
                case "4":
                    AddGrade(60);
                    break;
                case "-4":
                case "4-":
                    AddGrade(55);
                    break;
                case "+4":
                case "4+":
                    AddGrade(65);
                    break;
                case "3":
                    AddGrade(40);
                    break;
                case "-3":
                case "3-":
                    AddGrade(35);
                    break;
                case "+3":
                case "3+":
                    AddGrade(45);
                    break;
                case "2":
                    AddGrade(20);
                    break;
                case "-2":
                case "2-":
                    AddGrade(15);
                    break;
                case "+2":
                case "2+":
                    AddGrade(25);
                    break;
                case "1":
                    AddGrade(0);
                    break;
                case "+1":
                case "1+":
                    AddGrade(5);
                    break;
                default:
                    throw new Exception("Wrong digit, please use 1 - 6");
            }
            return;

        }
        public void AddGrade(char grade)
        {

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
            var statistics2 = new statistics();
            statistics2.Average = 0;
            statistics2.Max = float.MinValue;
            statistics2.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics2.Max = Math.Max(statistics2.Max, grade);
                statistics2.Min = Math.Min(statistics2.Min, grade);
                statistics2.Average += grade;
            }

            statistics2.Average /= this.grades.Count;

            switch (statistics2.Average)
            {
                case var average when average >= 80:
                    statistics2.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics2.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics2.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics2.AverageLetter = 'D';
                    break;
                default:
                    statistics2.AverageLetter = 'E';
                    break;
            }
            return statistics2;
        }
    }
}
