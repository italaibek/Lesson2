using System;
using static System.Console;

Clear();

Write("Введите N: ");
int n=int.Parse(ReadLine());

for(int i=1; i<=n;i++){
    WriteLine($"\"{i}\" в квадрате \"{i * i}\" ");
}