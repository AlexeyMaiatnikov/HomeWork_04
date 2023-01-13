/*
Напишите программу, реализующую метод,который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B с использованием цикла.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
using static System.Console;
Clear();
Write("Введите число A: ");
int numberA = int.Parse(ReadLine()!);
Write("Введите число B: ");
int numberB = int.Parse(ReadLine()!);

int Exp = GetExp(numberA, numberB);
WriteLine($"{numberA} в степени {numberB} = {Exp}");


int GetExp(int a, int b)
{
    int result = 1;
    if (b < 0)
    {
        b = b * -1;
    }
    while (b > 0)
    {

        result = result * a;
        b = b - 1;
    }
    return result;
}