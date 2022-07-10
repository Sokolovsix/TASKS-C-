Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int min = -n;

while (min <= n)
{
    Console.Write(min + " ");
    min++;
}
