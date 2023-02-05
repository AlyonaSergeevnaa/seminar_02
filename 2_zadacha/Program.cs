// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

System.Console.WriteLine("vvedite chislo" );
int a = Convert.ToInt32(Console.ReadLine());

if (a<99)

{
    System.Console.WriteLine("tretiey cifry net");
}

else 
{
    while (a>999)
{
    a/=10;
}
System.Console.WriteLine(a%10);
}
