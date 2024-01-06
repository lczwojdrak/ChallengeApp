using ChallengeApp;

var employee = new Employee("Łukasz", "Czwojdrak");
employee.AddGrade(2);
employee.AddGrade(5);
employee.AddGrade(6);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Min}");
Console.WriteLine($"Min: {statistics.Max}");

SetSth(out statistics);

void SetSth(out statistics statistics)
{
   statistics = new statistics();
}
