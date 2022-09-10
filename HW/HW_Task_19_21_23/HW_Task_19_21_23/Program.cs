// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5-> 1, 8, 27, 64, 125


Console.WriteLine("Введите положительное число");
bool IsNumber = int.TryParse(Console.ReadLine(), out int N);


if (!IsNumber)
{
    Console.WriteLine("Не число");
    return;
}

PrintCubes (GetCubes(N));
int[] GetCubes(int n)
{
    int i = 1;
    int[] results = new int[n];
    while (i <= n)
    {
        results[i-1] = (int) Math.Pow (i,3);
        i++;
    }
    return results;
}

void PrintCubes(int[] cubes)
{
    int i = 0;
    int len = cubes.Length;
    while (i < len)
    {
        Console.WriteLine(cubes[i]);
        i++;
    }
}