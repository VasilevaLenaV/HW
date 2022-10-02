//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []


string[] arr = new string[] { "Hello", "2", "world", ":-)" };


string[] GetArrayLessThree(string[] strArray)
{

    var index = 0;
    var res = new string[] { };

    for (int i = 0; i < strArray.Length; i++)
    {
        if (strArray[i].Length <= 3)
        {
            Array.Resize(ref res, ++index);
            res[index - 1] = strArray[i];
        }
    }

    return res;
}

void PrintArray(string[] arrayOutput)
{

    if (arrayOutput.Length == 0)
        return;

    Console.WriteLine("Новый массив из строк, длина которых меньше, либо равна 3 символам:");

    for (int i = 0; i < arrayOutput.Length; i++)
    {
        Console.Write($"{arrayOutput[i]}\t");
    }
}

ConsoleKey response;
do
{
    Console.WriteLine("Ввести массив с клавиатуры? [y - yes/ n - no] ");
    response = Console.ReadKey(false).Key;

    if (response != ConsoleKey.Enter)
        Console.WriteLine();

    if (response == ConsoleKey.Escape)
        break;


} while (response != ConsoleKey.Y && response != ConsoleKey.N);

if (response == ConsoleKey.Escape)
    return;

var res = response == ConsoleKey.Y;

if (res)
{
    Console.WriteLine("Введите массив через запятую: ");
    var inputArray = Console.ReadLine();

    if (inputArray?.Length == 0)
    {
        Console.WriteLine("Ошибка ввода массива");
        return;
    }

    var arrStr = inputArray?.Split(',');

    if (arrStr?.Length > 0)
    {
        PrintArray(GetArrayLessThree(arrStr));
    }
}
else
{
    PrintArray(GetArrayLessThree(arr));
}
