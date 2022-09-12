// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int count = 0;

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);

        if (numbers[i] % 2 == 0)
            count++;
    }
}

Console.WriteLine("Задача 34. Введите размер массива:");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[sizeArray];

FillArrayRandomNumbers(numbers);

Console.WriteLine($"Массив: [{string.Join(',', numbers)}]");
Console.WriteLine($"{count} - количество четных чисел в массиве");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int countNumber = 0;
int sumItems = 0;

int[] FillArrayRandNumber(int sizeArray1)
{
    var res = new int[sizeArray1];

    for (int i = 0; i < sizeArray1; i++)
    {
        res[i] = new Random().Next(100);

        if (i % 2 != 0)
            sumItems += res[i];

        countNumber++;
    }
    return res;
}

Console.WriteLine("Задача 36. Введите размер массива:");

int.TryParse(Console.ReadLine(), out int sizeArray1);
var arrayNumbers = FillArrayRandNumber(sizeArray);

Console.WriteLine($"Массив: [{string.Join(',', arrayNumbers)}]");
Console.WriteLine($"Сумму элементов, стоящих на нечётных позициях: {sumItems}");



//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


int countNum = 0;
int sumItem = 0;

float[] FillArrayRandomNum(int sizeArray2)
{
    var res = new float[sizeArray2];
    Random rand = new Random();
    double GetRandomNumber(double minimum, double maximum)
    {
        return rand.NextDouble() * (maximum - minimum) + minimum;
    }

    for (int i = 0; i < sizeArray2; i++)
    {
        res[i] = (float)GetRandomNumber(0, 100);
        countNum++;
    }
    return res;
}

Console.WriteLine("Задача 38. Введите размер массива:");

int.TryParse(Console.ReadLine(), out int sizeArray2);
var arrayNumber = FillArrayRandomNum(sizeArray2);

Console.WriteLine($"Массив: [{string.Join(',', arrayNumber)}]");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {arrayNumber.Max() - arrayNumber.Min()}");