// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 --> 46
// 782 --> 72
// 918 -- 98



Random rnd = new Random();

int a = rnd.Next(100,1000);

System.Console.WriteLine(a);

int firstNumber = a/100;
int lastNumber = a%10;

a = firstNumber*10+lastNumber;

System.Console.WriteLine(a);

