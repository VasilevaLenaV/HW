// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


bool IsPalindrome(string numbersCombination)
{
    if (numbersCombination[0] == numbersCombination[4] && numbersCombination[1] == numbersCombination[3])
        return true;

    return false;
}

var input = Convert.ToString(Console.ReadLine());

bool result = IsPalindrome(input);
Console.WriteLine(result ? "Да, это палиндром" : "Нет, это не палиндром");