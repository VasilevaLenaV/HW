// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int GetPositiveValuesCount(string strArray)
{
    var positiveArray = strArray.Split(',');
    var res = 0;

    for (int i = 0; i < positiveArray.Length; i++)
    {
        if (int.TryParse(positiveArray[i], out int itemValue) && itemValue > 0)
        {
            res++;
        }
    }
    return res;
}

Console.WriteLine("Введите числа через запятую:");
var inputArray = Console.ReadLine();

if (inputArray == null || inputArray == "")
    return;

Console.WriteLine($"Кол-во положительных элементов: {GetPositiveValuesCount(inputArray)}");
