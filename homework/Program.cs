﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
/*int a = 5;
int b = 7;
if (a>b)
{
    Console.WriteLine("число{a} больше числа {b} ");
}
else
{
    Console.WriteLine("число{b} больше числа {a} ");
}*/
/*int a = 2;
int b = 10;
if (a>b)
{
    Console.WriteLine("число{a} больше числа {b} ");
}
else
{
    Console.WriteLine("число{b} больше числа {a} ");
}*/
//int a = -9;
//int b = -3;
//if (a>b)
//{
    //Console.WriteLine("число{a} больше числа {b} ");
//}
//else
//{
    //Console.WriteLine("число{b} больше числа {a} ");
//}
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22//

/*int a = 22;
int b = 3; 
int c = 9;
int m = a;
if (b>a)
{
    m = b;
}
if (c > m)
{
    m = c;
} 
Console.Write(m);*/

 //Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет    
/*int a = 7;
if (a % 2 == 0)
{
Console.WriteLine("число а-четное ");
}
else
{
Console.WriteLine("число а-нечетное ");
}*/      
        
    //Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine("ВВЕДИТЕ ЧИСЛО N ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i=0; i<10; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}       
