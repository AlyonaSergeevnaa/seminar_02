// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("vveditee chislo =  ");

int number = Convert.ToInt32(Console.ReadLine());
if (number>99 && number<1000)

{
   
    int a = number/10%10;
    System.Console.WriteLine (a);
}

else

{

System.Console.WriteLine("chislo ne trehznachnoe");

} 