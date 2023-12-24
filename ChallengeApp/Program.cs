//Zadanie Domowe 6

using ChallengeApp;

Employee user1 = new Employee("Kamila", "Popłocka", 31);
Employee user2 = new Employee("Łukasz", "Czwojdrak", 32);
Employee user3 = new Employee("Marta", "Żuk", 33);


//User1
user1.AddScore(5);
user1.AddScore(2);
user1.AddScore(6);
user1.AddScore(9);
user1.AddScore(14);

//User2
user2.AddScore(3);
user2.AddScore(7);
user2.AddScore(8);
user2.AddScore(3);
user2.AddScore(8);

//User3
user3.AddScore(9);
user3.AddScore(7);
user3.AddScore(5);
user3.AddScore(3);
user3.AddScore(10);

var result1 = user1.Result;
var result2 = user2.Result;
var result3 = user3.Result;

int maxscore = Math.Max(result1, (Math.Max(result2, result3)));

if (result1 >= maxscore)
{
    Console.WriteLine("Użytkownikiem z największą ilością punktów jest " + user1.Login + " " + user1.Surname + " lat " + user1.Age);
}

else if (result2 >= maxscore)
{
    Console.WriteLine("Użytkownikiem z największą ilością punktów jest " + user2.Login + " " + user2.Surname + " lat " + user2.Age);
}

else if (result3 >= maxscore)
{
    Console.WriteLine("Użytkownikiem z największą ilością punktów jest " + user3.Login + " " + user3.Surname + " lat " + user3.Age);
}

