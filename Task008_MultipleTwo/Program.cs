Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 % 7 == 0 && number1 % 23 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Нет");
}