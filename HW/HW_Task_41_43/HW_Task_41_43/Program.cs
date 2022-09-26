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