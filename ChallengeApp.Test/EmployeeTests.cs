
namespace ChallengeApp.Test
{
    internal class EmployeeTests
    {
        [Test]
        public void CorrectPoints()
        {
            var employee = new Employee("Łukasz", "Czwojdrak");
            employee.AddGrade(5);
            employee.AddGrade(10);
            employee.AddGrade(6);
            employee.AddGrade('A');
            employee.AddGrade(101);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(statistics.Min, 5);
            Assert.AreEqual(statistics.Max, 100);
            Assert.AreEqual(statistics.Average, 30, 25);
            Assert.AreEqual(statistics.AverageLetter, 'D');
            Assert.AreNotEqual(statistics.AverageLetter, 'E');

        }

    }
}
