int number = 4594;
string numberAsString = number.ToString();
char[] signs = numberAsString.ToCharArray();

Console.WriteLine("Wyniki dla liczby_" + number);
int sign0 = 0;
int sign1 = 0;
int sign2 = 0;
int sign3 = 0;
int sign4 = 0;
int sign5 = 0;
int sign6 = 0;
int sign7 = 0;
int sign8 = 0;
int sign9 = 0;


foreach (char sign in signs)
    {
        if (sign == '0')
        {
            sign0++;
        }
        else if (sign == '1')
        {
            sign1++;
        }
        else if (sign == '2')
        {
            sign2++;
        }
        else if (sign == '3')
        {
            sign3++;
        }
        else if (sign == '4')
        {
            sign4++;
        }
        else if (sign == '5')
        {
            sign5++;
        }
        else if (sign == '6')
        {
            sign6++;
        }
        else if (sign == '7')
        {
            sign7++;
        }
        else if (sign == '8')
        {
            sign8++;
        }
        else if (sign == '9')
        {
            sign9++;
        }
     
    }
Console.WriteLine("Liczba 0>>" + sign0);
Console.WriteLine("Liczba 1>>" + sign1);
Console.WriteLine("Liczba 2>>" + sign2);
Console.WriteLine("Liczba 3>>" + sign3);
Console.WriteLine("Liczba 4>>" + sign4);
Console.WriteLine("Liczba 5>>" + sign5);
Console.WriteLine("Liczba 6>>" + sign6);
Console.WriteLine("Liczba 7>>" + sign7);
Console.WriteLine("Liczba 8>>" + sign8);
Console.WriteLine("Liczba 9>>" + sign9);

Console.WriteLine("Zadanie domowe Dzień 5 SKOŃCZONE");
