﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = Random.Shared.Next(100, 1000);
Console.WriteLine(number);
int LastTwoDigit = number / 10;
int secondDigit = LastTwoDigit % 10;
Console.WriteLine(secondDigit);