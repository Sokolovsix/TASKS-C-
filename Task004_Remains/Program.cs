﻿Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 99)
{
    if(number < 1000)
    {
         int result = number % 10;
         Console.WriteLine(result);
    }
}