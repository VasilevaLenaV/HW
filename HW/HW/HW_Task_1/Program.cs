//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int thirdNumber(int number)
{
    int secondDigit = (number % 100) / 10;
    return secondDigit;
}

var input = Convert.ToInt32(Console.ReadLine());   // int.TryParse(Console.ReadLine(), out int input); -вариант для обработки неверного ввода(например, текста)
Console.WriteLine($"Вторая цифра - {thirdNumber(input)}");