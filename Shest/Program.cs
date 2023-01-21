Console.WriteLine ("Введите число ");
int numberA = int.Parse (Console.ReadLine());
int numberB = (numberA % 10);
int LastNumber = (numberA % 100 - numberB)/10;
Console.WriteLine (LastNumber);
// не забыть попробоавть через string