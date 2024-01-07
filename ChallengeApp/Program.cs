﻿using ChallengeApp;

var employee = new Employee("Łukasz", "Czwojdrak");
employee.AddGrade("Adam");
employee.AddGrade("11");
employee.AddGrade(5);
employee.AddGrade(6);
employee.AddGrade(13,9);

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
 
SetSth(out statistics);

void SetSth(out statistics statistics)
{
   statistics = new statistics();
}
