
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

            var statistics = employee.GetStatistics();

            Assert.AreEqual(statistics.Min, 5);
            Assert.AreEqual(statistics.Max, 10);
            Assert.AreEqual(statistics.Average, 7);

            Assert.AreNotEqual(statistics.Min, 1);
            Assert.AreNotEqual(statistics.Max, 12);
            Assert.AreNotEqual(statistics.Average, 5);

        }

    }
}
