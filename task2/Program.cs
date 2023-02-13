// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9

Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
int max = A;

Console.WriteLine("Введите число");
int B = Convert.ToInt32(Console.ReadLine());
int min = B;

if (A > B)
{
    Console.WriteLine($"max = {A}, min = {B}");
}
else Console.WriteLine($"max = {B}, min = {A}");