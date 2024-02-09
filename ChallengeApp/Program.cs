using ChallengeApp;

Console.WriteLine("Witam w programie XYZ do oceny Pracowników i Kadry Kierowniczej");
Console.WriteLine("W celu przejścia do oceny Kierownika lub zakończenia wpisywania ocen wciśnij 'q'");
Console.WriteLine("==========================================\n\n");

var employee = new Employee("Łukasz", "Czwojdrak");
var supervisor = new Supervisor("Łukasz", "Czwojdrak");


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


while (true)
{
    Console.WriteLine("Podaj kolejną ocenę kierownika:");
    var input = Console.ReadLine();

    if (input == "q")
    {
        break;
    }
    try
    {
        supervisor.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

Console.WriteLine("==========================================\n\n");
Console.WriteLine("PRACOWNICY");

Console.WriteLine("Średnia ocena dla pracownika wynosi:");
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Average Letter: {statistics.AverageLetter:N2}");
Console.WriteLine($"Max: {statistics.Max:N2}");
Console.WriteLine($"Min: {statistics.Min:N2}");

Console.WriteLine("==========================================\n\n");
Console.WriteLine("KIEROWNICY");

Console.WriteLine("Średnia ocena dla Kierownika wynosi:");
var statistics2 = supervisor.GetStatistics();
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Average Letter: {statistics2.AverageLetter:N2}");
Console.WriteLine($"Max: {statistics2.Max:N2}");
Console.WriteLine($"Min: {statistics2.Min:N2}");
