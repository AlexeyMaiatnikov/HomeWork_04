/*Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
using static System.Console;
Clear();
Write("Введите число: ");
int number = int.Parse(ReadLine()!);
int SumNum = GetSumNum(number);
WriteLine($"Сумма цифр в числе {number} = {SumNum}");

int GetSumNum(int num)
{
    int result = 0;
    while (num > 0)
    {
        result = result + num % 10;
        num = num / 10;
    }

    return result;
}