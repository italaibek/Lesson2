using System;
using static System.Console;
Clear();


Write("Введите число: ");
      string chislo = ReadLine();
        if  (chislo.Length < 3)
        {
            WriteLine("Третьей цифры нет");
        }
        else
        {WriteLine(chislo[2]);
            
        }