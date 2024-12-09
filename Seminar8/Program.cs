using System;
using static System.Console;

Clear();

Write("Введите x1: ");
int x1=int.Parse(ReadLine());
Write("Введите y1: ");
int y1=int.Parse(ReadLine());
Write("Введите x2: ");
int x2=int.Parse(ReadLine());
Write("Введите y2: ");
int y2=int.Parse(ReadLine());

double d=Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
WriteLine($"Длина отрезка = {d:f2}");