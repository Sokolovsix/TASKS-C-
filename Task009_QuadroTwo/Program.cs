﻿Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int firstQuadro = number1 * number1;
int secondQuadro = number2 * number2;

if (firstQuadro == number2 || secondQuadro == number1)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}