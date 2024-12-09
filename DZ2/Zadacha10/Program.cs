using System;
using static System.Console;
Clear();

Write("Введите трехзначное число: ");
        int number = int.Parse(ReadLine());

        // Получаем вторую цифру числа
        int secondDigit = (number / 10) % 10;

WriteLine($"Число: {number} Вторая цифра числа: " + secondDigit);
    