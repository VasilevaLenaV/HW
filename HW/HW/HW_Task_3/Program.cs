//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool isWeekand(int day)
{
    if (day > 5 && day <= 7)
        return true;

    return false;
}

var input = Convert.ToInt32(Console.ReadLine());
bool result = isWeekand(input);
Console.WriteLine(result ? "Да" : "Нет");

