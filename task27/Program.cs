// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numberA)
  {  
    int B = Convert.ToString(numberA).Length;
    int C = 0;
    int result = 0;

    for (int i = 0; i < B; i++){
      C = numberA - numberA % 10;
      result = result + (numberA - C);
      numberA = numberA / 10;
    }
   return result;
  }

int sumNumber = SumNumber(numberA);
Console.WriteLine(sumNumber);