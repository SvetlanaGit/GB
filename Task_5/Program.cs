// Напишите программу, которая на входе принимает трехзначное число,а на выходе выдает последнюю цифру.

Console.WriteLine("--> ");
int a = Convert.ToInt32(Console.ReadLine());

if ((a<1000) && (a>99))
{
    int b = a%10;
    System.Console.WriteLine(b);
}
else
{
    System.Console.WriteLine("Щшибка!");
}