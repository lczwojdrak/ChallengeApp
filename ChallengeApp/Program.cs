// var myAge = 36;

// liczby całkowite
int myAge = 120;
int newAge = myAge + 5;
int myVar = int.MinValue;
uint myVar2 = uint.MaxValue;
ulong myVar3 = ulong.MaxValue;

// liczby zmiennoprzecinkowe
float myNumber = float.MaxValue;
double myNumber2 = double.MaxValue;

// zmienne tekstowe
string name = "Lukasz";
string surname = "Czwojdrak";
string result = name + surname + myAge;
// Console.WriteLine(result);
char myVar5 = 'c';
var result2 = name.ToArray();

// zmiennna logiczna
bool isActive = true;
isActive = false;
var isValid = 5 > 6;
// Console.WriteLine(isValid);

var number1 = 50;
var number2 = 10;

var name2 = "Łukasz";
var age2 = 36;


if (name2 == "Łukasz" || age2 < 50)
{
    // Console.WriteLine("Jestem Łukasz przed 50");
}
else
{
    // Console.WriteLine("Jestem kimś innym");
}

// zadanie domowe
string nameNew = "Ewa";
string genNew = "Kobieta";
var ageNew = 30;

if (genNew == "Kobieta" && ageNew < 30)

    Console.WriteLine("Kobieta poniżej 30 lat.");

if (nameNew == "Ewa" && ageNew == 30 && genNew == "Kobieta")

    Console.WriteLine("Ewa, lat 30.");

if (genNew == "Mężczyzna" && ageNew < 18)

    Console.WriteLine("Niepełnoletni mężczyzna.");


