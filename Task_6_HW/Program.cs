// Напишите программу, которая на вход принимает два числа и выдает, какое число большее.




Console.WriteLine("Введите первое число 1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
if(b>max)max=b;

System.Console.WriteLine(max);