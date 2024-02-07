using ChallengeApp;

Console.WriteLine("Witam w programie XYZ do oceny Pracowników");
Console.WriteLine("W celu zakończenia wpisywania ocen wciśnij 'q'");
Console.WriteLine("==========================================\n\n");

var employee = new Employee("Łukasz", "Czwojdrak", "Mężczyzna", 36);


while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika:");
    var input = Console.ReadLine();

    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Average Letter: {statistics.AverageLetter:N2}");
Console.WriteLine($"Max: {statistics.Max:N2}");
Console.WriteLine($"Min: {statistics.Min:N2}");
