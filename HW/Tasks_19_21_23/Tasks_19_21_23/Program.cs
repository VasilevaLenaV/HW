// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool IsPalindrome(string numbersCombination)
{
    if (!IsNumbers(numbersCombination))
        return false;

    if (numbersCombination[0] == numbersCombination[4] && numbersCombination[1] == numbersCombination[3])
        return true;

    return false;
}
bool IsNumbers(string numbersCombination)
{
    return numbersCombination.Length == 5 && int.TryParse(numbersCombination, out int res);
}

var input = Convert.ToString(Console.ReadLine());

bool result = IsPalindrome(input);
Console.WriteLine(result ? "Да, это палиндром" : "Нет, это не палиндром");



// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.53


static double DistanceAB(Coord p1, Coord p2)
{
    return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X)
                     + (p1.Y - p2.Y) * (p1.Y - p2.Y)
                     + (p1.Z - p2.Z) * (p1.Z - p2.Z));
}

static Coord SetCoord()
{
    Console.Write("Введите координаты x: ");
    var x = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координаты y: ");
    var y = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координаты z: ");
    var z = Convert.ToDouble(Console.ReadLine());
    return new Coord { X = x, Y = y, Z = z };
}

Console.WriteLine("Введите первую точку:");
var p1 = SetCoord();
Console.WriteLine("Введите вторую точку:");
var p2 = SetCoord();
var distance = DistanceAB(p1, p2);
Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance:F2}");

class Coord
{
    public double X, Y, Z;
}


//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



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

PrintCubes(GetCubes(N));
int[] GetCubes(int n)
{
    int i = 1;
    int[] results = new int[n];
    while (i <= n)
    {
        results[i - 1] = (int)Math.Pow(i, 3);
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

