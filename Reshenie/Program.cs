/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine ("Введите координату x первой точки: ");
int userX1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите координату y первой точки: ");
int userY1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите координату a первой точки: ");
int userA1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите координату a второй точки: ");
int userX2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите координату y второй точки: ");
int userY2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите координату a второй точки: ");
int userA2 = Convert.ToInt32(Console.ReadLine());

double segment = Math.Sqrt((userA2 - userA1) * (userA2 - userA1) + (userY2 - userY1) * (userY2 - userY1) + (userX2 - userX1) * (userX2 - userX1));
segment = Math.Round(segment, 2);
Console.WriteLine($"Расстояние между точками равно: {segment}");