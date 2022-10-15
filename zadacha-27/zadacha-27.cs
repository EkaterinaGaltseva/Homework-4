/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

Console.Write("Введите число N: ");
string NumberN = Console.ReadLine();
int NumN = int.Parse(NumberN);
int summ = 0;
while (NumN > 0)
{
    summ = summ + NumN % 10;
    NumN = NumN / 10; 

}
Console.Write($"{NumberN} -> {summ} ");
