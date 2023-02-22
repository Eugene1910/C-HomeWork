// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (номер цифры считается от левого края)

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


int number = Random.Shared.Next();
Console.WriteLine(number);
if (number > 99)
{
int d = GetThirdDigit(number);
Console.WriteLine(d);

int GetThirdDigit(int s)
{
while (s >= 1000) s /= 10;
int d = s % 10;
return d;
}
}
else Console.WriteLine("третьей цифры нет");

