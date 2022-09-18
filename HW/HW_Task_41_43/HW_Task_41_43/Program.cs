//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int[] GetArray(string inputArrayStr)
{
    var arrSize = 0;
    var resArray = new int[] { };
    var strArray = inputArrayStr.Split(',');

    foreach (var item in strArray)
    {
        if (int.TryParse(item, out int itemValue))
        {
            Array.Resize(ref resArray, resArray.Length + 1);
            resArray[arrSize] = itemValue;

            arrSize++;
        }
    }
    Console.WriteLine($"{string.Join(',', resArray)}");

    return resArray;
}

int GetCountPositiveValues(int[] arrayValues)
{
    var count = 0;

    if (arrayValues.Length == 0)
        return 0;

    foreach (var item in arrayValues)
    {
        if (item > 0)
        {
            count++;
        }
    }

    return count;
}


Console.WriteLine("Задача 41. Введите числа через запятую:");
var inputArray = Console.ReadLine();

if (inputArray == null || inputArray == "")
    return;

var strArray = GetArray(inputArray);
var positiveCount = GetCountPositiveValues(strArray);

Console.WriteLine($"Кол-во положительных элементов: {positiveCount}");


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

Console.WriteLine("Задача 43. Введите значение k1:");
float.TryParse(Console.ReadLine(), out float k1);
Console.WriteLine("Введите значение k2:");
float.TryParse(Console.ReadLine(), out float k2);
Console.WriteLine("Введите значение b1:");
float.TryParse(Console.ReadLine(), out float b1);
Console.WriteLine("Введите значение b2:");
float.TryParse(Console.ReadLine(), out float b2);

if (!CheckLine(k1, k2, b1, b2))
    return;

var pointIntersectX = GetPointIntersectionX(k1, k2, b1, b2);
var pointIntersectY = GetPointIntersectionY(k1, k2, b1, b2);

Console.WriteLine($"Точка пересечения прямых:({pointIntersectX},{pointIntersectY})");

bool CheckLine(float k1, float k2, float b1, float b2)
{
    var res = true;

    if ((k1 == k2) && (b1 == b2))
    {
        Console.WriteLine("Прямые совпадают");
        return res;
    }
    else if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны");
        return res;
    }
    return res;
}

float GetPointIntersectionX(float k1, float k2, float b1, float b2) => ((b2 - b1) / (k1 - k2));
float GetPointIntersectionY(float k1, float k2, float b1, float b2) => ((k1 * (b2 - b1)) / (k1 - k2) + b1);