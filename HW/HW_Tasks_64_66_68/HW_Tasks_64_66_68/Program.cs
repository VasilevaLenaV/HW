// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


int[] GetNaturalNumber(int m, int n)
{
    var size = n - m > 0 ? n - m + 1 : 0;
    var naturalArr = new int[size];

    for (int i = 0; m <= n; i++)
    {
        naturalArr[i] = m;
        m++;
    }

    return naturalArr;
}

bool CheckInput(int m, int n)
{
    if (m == 0 || n == 0)
    {
        Console.WriteLine($"Значение M или N не может быть меньше 1");
        return false;
    }
    if (m > n)
    {
        Console.WriteLine($"Значение N не может быть меньше M");
        return false;
    }

    if (n == m)
    {
        Console.WriteLine(n);
        return false;
    }
    return true;
}

void PrintArray(int[] arrayOutput)
{
    for (int i = 0; i < arrayOutput.Length; i++)
    {
        Console.Write($"{arrayOutput[i]}\t");
    }
}

Console.WriteLine("Задача 64. Задайте значения M");
int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Задайте значения N");
int.TryParse(Console.ReadLine(), out int n);

if (!CheckInput(m, n))
    return;

var arr = GetNaturalNumber(m, n);
PrintArray(arr);


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30

int[] GetNaturalNumber1(int m1, int n1)
{
    var size = n1 - m1 > 0 ? n1 - m1 + 1 : 0;
    var naturalArr = new int[size];

    for (int i = 0; m1 <= n1; i++)
    {
        naturalArr[i] = m1;
        m1++;
    }

    return naturalArr;
}

int GetSumNatNumber(int[] numbs)
{
    var res = 0;
    for (int i = 0; i < numbs.Length; i++)
    {
        res += numbs[i];
    }

    return res;
}

bool CheckInput1(int m1, int n1)
{
    if (m1 == 0 || n1 == 0)
    {
        Console.WriteLine($"Значение M или N не может быть меньше 1");
        return false;
    }
    if (m1 > n1)
    {
        Console.WriteLine($"Значение N не может быть меньше M");
        return false;
    }

    if (n1 == m1)
    {
        Console.WriteLine(n1);
        return false;
    }
    return true;
}

Console.WriteLine("Задача 66. Задайте значения M");
int.TryParse(Console.ReadLine(), out int m1);
Console.WriteLine("Задайте значения N");
int.TryParse(Console.ReadLine(), out int n1);

if (!CheckInput(m1, n1))
    return;

var arr1 = GetNaturalNumber(m1, n1);
var sumNatNumber = GetSumNatNumber(arr);

Console.WriteLine($"Сумму натуральных элементов в промежутке от {m1} до {n1} равна {sumNatNumber}");



//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3->A(m, n) = 29

int Akk(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Akk(n - 1, 1);
    if (n > 0 && m > 0) return Akk(n - 1, Akk(n, m - 1));
    return Akk(n, m);
}


bool CheckInput2(int m, int n)
{
    if (m == 0 || n == 0)
    {
        Console.WriteLine($"Значение M или N не может быть меньше 0");
        return false;
    }

    return true;
}

Console.WriteLine("Задача 68. Задайте значения M");
int.TryParse(Console.ReadLine(), out int m2);

Console.WriteLine("Задайте значения N");
int.TryParse(Console.ReadLine(), out int n2);

if (!CheckInput(m, n))
    return;

var akkNumber = Akk(n, m);
Console.WriteLine($"A(n, m) = {akkNumber}");