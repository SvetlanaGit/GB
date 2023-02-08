// Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.



// int rnd = newRandom();
// int a = rnd.Next(10,100):

int Max (int a, int b)
{
    if (a>b) return a;
    else return b;
}

Random rnd = new Random();
int a = rnd.Next(10,100);
System.Console.WriteLine($"Random = {a}");

int firstNumber = a/10;
int secondNumber = a%10;

int max = Max(firstNumber, secondNumber);
System.Console.WriteLine($"Max = {max}");

