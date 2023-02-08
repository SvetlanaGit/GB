//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6




Console.WriteLine("--> ");

int n  = Convert.ToInt16(Console.ReadLine());

int result = (n%100)/10;

System.Console.WriteLine("Вторая цифра: " + result);
