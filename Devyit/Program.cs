// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine ("Введите число ");
int numberA = int.Parse (Console.ReadLine ());
int numberB = 6;
if (numberB < numberA) {Console.Write ("Введеное число больше заданного, картность равна 0");}
if (numberB % numberA == 0) {Console.Write ("Числа кратные");}
if (numberB / numberA == numberA) {Console.Write (numberA);}
