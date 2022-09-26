// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] FillArray(int m, int n)
{
    int[,] resArray = new int[m, n];

    Console.WriteLine("Массив:");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resArray[i, j] = new Random().Next(0, 100);

            Console.Write(resArray[i, j] + " ");
        }
        Console.WriteLine();
    }
    return resArray;
}

void SortedArray(int[,] resFill)
{
    for (int i = 0; i < resFill.GetLength(0); i++) //n
    {
        for (int j = 0; j < resFill.GetLength(1) - 1; j++) //m
        {
            for (int k = j + 1; k < resFill.GetLength(1); k++)
            {
                if (resFill[i, j] < resFill[i, k])
                {
                    var temp = resFill[i, j];
                    resFill[i, j] = resFill[i, k];
                    resFill[i, k] = temp;
                }
            }
        }
    }
}

void PrintArray(int[,] arrayOutput)
{
    for (int i = 0; i < arrayOutput.GetLength(0); i++) //m
    {
        for (int j = 0; j < arrayOutput.GetLength(1); j++) //n
        {
            var nl = j == 0 ? "\n" : "";
            Console.Write($"{nl}{arrayOutput[i, j]} ");
        }
    }
}

Console.WriteLine("Задача 54. Введите размеры массива");
Console.WriteLine("Введите m");
int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите n");
int.TryParse(Console.ReadLine(), out int n);

var resFill = FillArray(m, n);

SortedArray(resFill);
PrintArray(resFill);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] FillArray1(int s)
{
    int[,] resArray1 = new int[s, s];

    Console.WriteLine("Массив:");
    for (int i = 0; i < s; i++)
    {
        for (int j = 0; j < s; j++)
        {
            resArray1[i, j] = new Random().Next(0, 100);
            Console.Write(resArray1[i, j] + " ");
        }
        Console.WriteLine();
    }
    return resArray1;
}

int GetMinSum(int[,] resFill)
{
    var rowNum = 0;
    var minSum = 0;

    for (int i = 0; i < resFill.GetLength(0); i++) //n
    {
        var rowSum = 0;

        for (int j = 0; j < resFill.GetLength(1); j++) //m
        {
            rowSum += resFill[i, j];
        }

        if (minSum == 0)
            minSum = rowSum;

        if (rowSum < minSum)
        {
            rowNum = i;
            minSum = rowSum;
        }
    }

    return rowNum;
}


Console.WriteLine("Задача 56. Введите размер массива");
int.TryParse(Console.ReadLine(), out int size);

var resFill1 = FillArray1(size);
var minRow = GetMinSum(resFill);

Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minRow + 1} строка");



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] FillMatrix(int s)
{
    var matrix = new int[s, s];

    for (var i = 0; i < s; i++)
    {
        for (var j = 0; j < s; j++)
        {
            matrix[i, j] = new Random().Next(0, 100);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (var i = 0; i < matrix.GetLength(0); i++)
    {
        for (var j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }

        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    var matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (var i = 0; i < matrixA.GetLength(0); i++)
    {
        for (var j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i, j] = 0;

            for (var k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }

    return matrixC;
}

Console.WriteLine("Задача 58. Введите размер матрицы:");
int.TryParse(Console.ReadLine(), out int size1);

var matrixA = FillMatrix(size);
var matrixB = FillMatrix(size);

/*для проверки*/
//matrixA = new int[2, 2] { { 2, 4 }, { 3, 2 } };
//matrixB = new int[2,2] { { 3, 4 }, { 3, 3 } };

var matrixC = MatrixMultiplication(matrixA, matrixB);

Console.WriteLine("Матрица А");
PrintMatrix(matrixA);

Console.WriteLine("Матрица B");
PrintMatrix(matrixB);

Console.WriteLine("Результирующая матрица:");
PrintMatrix(matrixC);


// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0, 1, 0)
// 34(1, 0, 0) 41(1, 1, 0)
// 27(0, 0, 1) 90(0, 1, 1)
// 26(1, 0, 1) 55(1, 1, 1)

int[,,] FillArray2(int s)
{
    int[,,] resArray = new int[s, s, s];

    var uniqItemArray = new int[resArray.Length];
    var uniqIndex = 0;

    for (int i = 0; i < s; i++)
    {
        for (int j = 0; j < s; j++)
        {
            for (int k = 0; k < s; k++)
            {
                var item = new Random().Next(10, 99);

                while (uniqItemArray.Contains(item))
                {
                    item = new Random().Next(10, 99);
                }
                resArray[i, j, k] = item;

                uniqItemArray[uniqIndex] = item;
                uniqIndex++;
            }
        }
    }
    return resArray;
}

void PrintArray2(int[,,] arrayOutput)
{
    for (int i = 0; i < arrayOutput.GetLength(0); i++)
    {
        for (int j = 0; j < arrayOutput.GetLength(1); j++)
        {
            for (int k = 0; k < arrayOutput.GetLength(1); k++)
            {
                var nl = (k == 0) ? "\n" : "";
                Console.Write($"{nl}{arrayOutput[i, j, k]}({i}, {j}, {k}) ");
            }
        }
    }
    Console.WriteLine();
}

Console.WriteLine("Задача 60. Введите размер трехмерного массива:");
int.TryParse(Console.ReadLine(), out int size2);

Console.WriteLine("\nТрехмерный массив:");
var array3D = FillArray2(size2);

PrintArray(array3D);


// Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillArray3(int s)
{
    int[,] arr = new int[s, s];

    int item = 1;
    int c1 = 0, c2 = s - 1;

    while (item <= s * s)
    {
        for (int i = c1; i <= c2; i++)
            arr[c1, i] = item++;

        for (int j = c1 + 1; j <= c2; j++)
            arr[j, c2] = item++;

        for (int i = c2 - 1; i >= c1; i--)
            arr[c2, i] = item++;

        for (int j = c2 - 1; j >= c1 + 1; j--)
            arr[j, c1] = item++;
        c1++;
        c2--;
    }

    return arr;
}

void PrintArray3(int[,] arrayOutput)
{
    for (int i = 0; i < arrayOutput.GetLength(0); i++)
    {
        for (int j = 0; j < arrayOutput.GetLength(1); j++)
        {
            Console.Write($"{arrayOutput[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Задача 62. Введите размер массива:");
int.TryParse(Console.ReadLine(), out int size3);

Console.WriteLine("\nМассив:");
var spiralArray = FillArray3(size3);

PrintArray(spiralArray);

