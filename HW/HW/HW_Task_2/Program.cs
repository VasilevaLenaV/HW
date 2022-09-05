// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int? thirdNumber(int n)
{
    if (n <= 99)
        return null;
    while (n > 999)
        n /= 10;

    return n % 10;
}

var input = Convert.ToInt32(Console.ReadLine());

var number = thirdNumber(input);

if (number == null)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine(number);
}

