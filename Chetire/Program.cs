﻿Console.WriteLine ("Введите число N ");
int numberA = int.Parse (Console.ReadLine());
for (int numberB = 1; numberB <= numberA; numberB++)
{
    if (numberB % 2 == 0)
    {
        Console.WriteLine (numberB);
    }
}
