// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5-> 243(3⁵)
// 2, 4-> 16


Console.WriteLine("Задача 25. Введите число A: ");
if (!uint.TryParse(Console.ReadLine(), out uint numberA))
{
    Console.WriteLine("ненатуральная степень");
    return;
}

Console.WriteLine("Задача 25. Введите число B ");  // uint отфильтрует ненатуральные числа
if (!uint.TryParse(Console.ReadLine(), out uint degreeB))
{
    Console.WriteLine("ненатуральная степень");
    return;
}

uint ExponentiateNumber(uint numberA, uint degreeB)
{
    uint result = 1;
    for (int i = 1; i <= degreeB; i++)
    {
        result = result * numberA;
    }
    return result;

}

Console.WriteLine($"число {numberA} в натуральной степени {degreeB} равняется {ExponentiateNumber(numberA, degreeB)}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.  
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Задача 27. Введите число: ");
int.TryParse(Console.ReadLine(), out int numberN);

int GetSumNumbers(int number)
{
    int count = 0;
    int sum = 0;
    int digit = 0;
    while (numberN > 0)
    {
        count++;
        digit = numberN % 10;
        sum += digit;
        numberN /= 10;
    }
    return sum;
}
int result = GetSumNumbers(numberN);
Console.WriteLine(result);



//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33-> [6, 1, 33]

Console.WriteLine("Задача 29. Введите длину массива:");
if (!int.TryParse(Console.ReadLine(), out int prmArrLength) || prmArrLength < 0)
{
    Console.WriteLine("Неверный ввод длины массива");
    return;
}

int[] FillArray(int lenArray)
{
    int[] res = new int[lenArray];
    var i = 0;

    Console.WriteLine("Введите массив через запятую: ");
    var prmArray = Console.ReadLine();

    foreach (var item in prmArray.Split(','))
    {
        if (i >= lenArray)
            return res;

        if (int.TryParse(item, out int arrItem))
        {
            res[i] = arrItem;
            i++;
        }
    }

    return res;
}

void PrintArray(int[] userArray)
{
    Console.WriteLine($"[{string.Join(',', userArray)}]");
}

var arr = FillArray(prmArrLength);
PrintArray(arr);