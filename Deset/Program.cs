
         // Найти третью цифру числа или сообщить, что её нет
Console.WriteLine ("Введите число ");
int numberA = int.Parse (Console.ReadLine ());

if (numberA < 100) {Console.Write ("У введеного числа нет третьей цифры");}
if (numberA >= 100) 
{
    int numberC = 10;
    for (int numberB = numberA / numberC; numberB > 100; numberC++)  
    {
        int length = numberB;
        Console.Write ( length );
    }
}


