//Удалить вторую цифру трёхзначного числа
Console.WriteLine ("Введите первое число ");
int number = int.Parse (Console.ReadLine ());
int A = number / 100;
int C = number % 10;
//int C = number % 10;
//int D = (B - C)/10;
Console.Write ($"{A} {C}");