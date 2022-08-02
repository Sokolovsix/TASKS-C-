// Принимаем X и Y не равные нулю и определяем номер четверти в плоскости

while(true)

{
    Console.Clear();
    int x = InputInt("Введите X: ");
    int y = InputInt("Введите Y: ");

    if(x == 0 || y == 0)
    {
        Console.WriteLine("X и Y не должны быть равны 0 ");
        Console.ReadKey();
        continue;
    }

    if(x > 0 && y > 0)
    {
        Console.WriteLine("1 четверть ");
    }
    else if(x < 0 && y > 0)
    {
        Console.WriteLine("2 четверть");
    }
    else if(x < 0 && y < 0)
    {
        Console.WriteLine("3 четверть");
    }
    else if(x > 0 && y < 0)
    {
        Console.WriteLine("4 четверть");
    }

    break;
}

int InputInt(string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}