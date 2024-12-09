using System;
using static System.Console;

Clear();
Write("Введите номер четверти:");
int n=int.Parse(ReadLine());

if(n==1){
    WriteLine("x>0 && y>0");
}

if(n==2){
    WriteLine("x>0 && y>0");
}

if(n==3){
    WriteLine("x<0 && y>0");
}

if(n==4){
    WriteLine("3 четверть");
}

if (n == 4) {
    WriteLine("x<0 && y<0");
}