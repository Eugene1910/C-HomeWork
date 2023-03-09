// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    double value = double.Parse(Console.ReadLine());
    return value;
}
double xa = ReadNumber("ВВедите координату точки A по X");
double ya = ReadNumber("ВВедите координату точки A по y");
double za = ReadNumber("ВВедите координату точки A по z");
double xb = ReadNumber("ВВедите координату точки B по X");
double yb = ReadNumber("ВВедите координату точки B по y");
double zb = ReadNumber("ВВедите координату точки B по z");

double res = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2));
Console.WriteLine($"{res:f2}");