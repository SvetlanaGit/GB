// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a=25, b=5, -- да.


System.Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a==(b*b))
{
    Console.WriteLine($"{a} квадрат {b}");
}
else
{
    System.Console.WriteLine("Не квадрат!");
}
