﻿/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

void GetNumber(int numberA, int numberB)
{
    double result = Math.Pow(numberA, numberB);
    Console.Write($"{numberA}, {numberB} -> {result} ");
}
Console.Write("Ввведите число А: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите число В: ");
int numB = int.Parse(Console.ReadLine());
GetNumber(numA, numB);

