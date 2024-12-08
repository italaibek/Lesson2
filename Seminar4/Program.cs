using System;
using static System.Console;
Clear();

WriteLine("Введите число: ");
int number = int.Parse(ReadLine());

if ((number % 7 == 0) && (number % 23 == 0))
{
    WriteLine($"{number}->да");
}
else
{
    WriteLine($"{number}->нет");
}