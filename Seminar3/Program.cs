// Принимаем X и Y не равные нулю и определяем номер четверти в плоскости

//while(true)

//{
//    Console.Clear();
//    int x = InputInt("Введите X: ");
//    int y = InputInt("Введите Y: ");

//    if(x == 0 || y == 0)
//    {
//        Console.WriteLine("X и Y не должны быть равны 0 ");
//        Console.ReadKey();
//        continue;
//    }

//    if(x > 0 && y > 0)
//    {
//        Console.WriteLine("1 четверть ");
//    }
//    else if(x < 0 && y > 0)
//    {
//        Console.WriteLine("2 четверть");
//    }
//    else if(x < 0 && y < 0)
//    {
//        Console.WriteLine("3 четверть");
//    }
//    else if(x > 0 && y < 0)
//    {
//        Console.WriteLine("4 четверть");
//    }

//    break;
//}

// int InputInt(string output)
//{
//    Console.WriteLine(output);
//    return Convert.ToInt32(Console.ReadLine());
//}

// Диапазон по заданному номеру четверти

//int guarter = InputInt("Введите номер четверти: ");

//if(guarter == 1)
//{
//    Console.WriteLine("x > 0, y > 0");
//}
//else if(guarter == 2)
//{
//    Console.WriteLine("x < 0, y > 0");
//}
//else if(guarter == 3)
//{
//    Console.WriteLine("x < 0, y < 0");
//}
//else if(guarter == 4)
//{
//    Console.WriteLine("x > 0, y < 0");
//}
//else
//{
//    Console.WriteLine("Четвертей всего четыре");
//}

//int InputInt(string output)
//{
//    Console.WriteLine(output);
//    return Convert.ToInt32(Console.ReadLine());
//}


// Расстояние между двумя точками в 2D пространстве

//int x1 = InputInt("Введите X1: ");
//int y1 = InputInt("Введите Y1: ");

//int x2 = InputInt("Введите X2 ");
//int y2 = InputInt("Введите Y2 ");

//int distanceX = x1 - x2;
//int distanceY = y1 - y2;

//double distance = Math.Sqrt(distanceX * distanceX + distanceY * distanceY);
//Console.WriteLine(distance);

//int InputInt(string output)
//{
//    Console.WriteLine(output);
//    return Convert.ToInt32(Console.ReadLine());
//}



// Таблица квадратов чисел от 1 до N

int n = InputInt("Введите число; ");
int min = 1;

while(min <= n)
{
    int result = Quadro(min);
    Console.Write(result + " ");
    min++;
}

int InputInt(string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}

int Quadro(int number)
{
    return number * number;
}