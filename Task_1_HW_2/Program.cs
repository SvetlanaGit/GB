﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1




Console.WriteLine("--> ");

int n  = Convert.ToInt16(Console.ReadLine());

int result = (n%100)/10;

System.Console.WriteLine("Вторая цифра: " + result);
