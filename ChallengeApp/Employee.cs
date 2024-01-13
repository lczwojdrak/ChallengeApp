using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
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
                Console.WriteLine("Invalid Grade Value");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("Float is not a value");
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
            return statistics;
        }
    }
}
