﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("vvedite chislo");
int a = Convert.ToInt32(Console.ReadLine());

if (a<1 || a>7)
{
System.Console.WriteLine("net takogo dnya");
}

else if  (a==6 || a==7)

{
    System.Console.WriteLine("da");
}

else
{

    System.Console.WriteLine("net");
}

