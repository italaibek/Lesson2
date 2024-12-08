using System;
using static System.Console;
Clear();

Write("Введите А:");
int A = int.Parse(Console.ReadLine());
Write("Введите В:");
int B = int.Parse(Console.ReadLine());

if(B*B==A){
    WriteLine("А является квадратом В");
}
else
{
    if(Math.Pow(A,2)==B)
    {
        WriteLine("B является квадратом А");
    }
    else{
        WriteLine("B не является квадратом А");
    }
}

