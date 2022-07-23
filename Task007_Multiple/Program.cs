Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int number3 = number1 % number2;
if (number3 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Остаток" + number3);
}

