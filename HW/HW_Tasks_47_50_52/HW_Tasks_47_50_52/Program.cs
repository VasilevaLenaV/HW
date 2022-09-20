// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 - 3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Задача 47. введите  значение m:");
int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите значение n:");
int.TryParse(Console.ReadLine(), out int n);

double[,] a = new double[m, n];

Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        a[i, j] = random.NextDouble() * 100;
        Console.Write("{0,6:F2}", a[i, j]);
    }
    Console.WriteLine();
}


//Задача 50.Напишите программу, которая на вход принимает число и ищет в двумерном массиве, и возвращает индексы этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//7-> 0 , 2
//5-> 1 , 0
//18->нет такого элемента

int[,] FillArray(int m1, int n1)
{
    int[,] resArray = new int[m1, n1];

    Console.WriteLine("Массив:");
    for (int i = 0; i < m1; i++)
    {
        for (int j = 0; j < n1; j++)
        {
            resArray[i, j] = new Random().Next(0, 100);

            Console.Write(resArray[i, j] + " ");
        }
        Console.WriteLine();
    }
    return resArray;
}

int[] CheckItem(int[,] arr, int m1, int n1, int x)
{
    for (int i = 0; i < m1; i++)
    {
        for (int j = 0; j < n1; j++)
            if (arr[i, j] == x)
            {
                return new int[] { i, j };
            }
    }
    return new int[] { };
}

Console.WriteLine("Задача 50. Введите размеры массива");
Console.WriteLine("Введите m");
int.TryParse(Console.ReadLine(), out int m1);
Console.WriteLine("Введите n");
int.TryParse(Console.ReadLine(), out int n1);

Console.WriteLine("Введите число для поиска в двумерном массиве");
int.TryParse(Console.ReadLine(), out int x);

var arr = FillArray(m1, n1);
var coord = CheckItem(arr, m1, n1, x);


if (coord.Length > 0)
{
    Console.WriteLine($"{coord[0]},{coord[1]}"); ;
}
else
{
    Console.WriteLine("нет такого элемента");
}



//Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillArrayy(int m2, int n2)
{
    int[,] resArray = new int[m2, n2];

    Console.WriteLine("Массив:");
    for (int i = 0; i < m2; i++)
    {
        for (int j = 0; j < n2; j++)
        {
            resArray[i, j] = new Random().Next(0, 100);

            Console.Write(resArray[i, j].ToString("F2") + " ");
        }
        Console.WriteLine();
    }
    return resArray;
}

double[] GetArithmeticAverage(int[,] arr, int m2, int n2)
{
    var res = new double[n2];

    int colSum;

    for (int j = 0; j < n2; j++)
    {
        colSum = 0;

        for (int i = 0; i < m2; i++)
        {
            colSum += arr[i, j];
        }

        res[j] = Convert.ToDouble(colSum) / Convert.ToDouble(m2);
    }
    return res;
}

void PrintArithmeticAverageArray(double[] arithmeticAverage)
{
    Console.WriteLine();
    for (int i = 0; i < arithmeticAverage.Length; i++)
    {
        Console.Write($"{arithmeticAverage[i]:F2};");
    }
}

Console.WriteLine("Задача 52. Введите размеры массива");
Console.WriteLine("Введите m");
int.TryParse(Console.ReadLine(), out int m2);
Console.WriteLine("Введите n");
int.TryParse(Console.ReadLine(), out int n2);

var resFill = FillArrayy(m2, n2);
var resArithmeticAverage = GetArithmeticAverage(resFill, m2, n2);

PrintArithmeticAverageArray(resArithmeticAverage);
