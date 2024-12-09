using System;
using static System.Console;
Clear();

Write("Введите число: ");
        int day = int.Parse(ReadLine());
if (day == 6 || day == 7)
{
    Write($"{day}->да");
}
else if (day >= 1 && day <= 5)
{
    Write($"{day}->нет");
}
else
{
    Write("Введите корректное число!");
}
    