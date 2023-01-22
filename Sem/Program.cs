//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int m =56;
int A = m / 10;
int B = m % 10;
if (A > B)
{
    Console.Write (A);
}
else
{
    Console.Write (B);
}