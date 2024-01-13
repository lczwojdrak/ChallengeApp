using ChallengeApp;

var employee = new Employee("Łukasz", "Czwojdrak");
employee.AddGrade("Adam");
employee.AddGrade("11");
employee.AddGrade(5);
employee.AddGrade(6);
employee.AddGrade(13.98);

var statistics = employee.GetStatistics();
var statistics2 = employee.GetStatisticsDoWhile();
var statistics3 = employee.GetStatisticsWhile();
var statistics4 = employee.GetStatisticsFor();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max:N2}");
Console.WriteLine($"Min: {statistics.Min:N2}");

setsth(out statistics);

void setsth(out statistics statistics)
{
    statistics = new statistics();
}

Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Max: {statistics2.Max:N2}");
Console.WriteLine($"Min: {statistics2.Min:N2}");

Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Max: {statistics3.Max:N2}");
Console.WriteLine($"Min: {statistics3.Min:N2}");

Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Max: {statistics4.Max:N2}");
Console.WriteLine($"Min: {statistics4.Min:N2}");