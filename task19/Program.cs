// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number,a,sum=0,b;
Console.Write("Введите пятизначное число:");
number = Convert.ToInt32(Console.ReadLine());
if(number>9999 && number<100000)
{
for(b=number;number!=0;number=number/10)
{
a = number % 10;
sum = sum * 10 + a;
}
if(b == sum)
Console.Write("yes");
else
Console.Write("no");
} else
Console.Write("error");