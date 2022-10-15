/*  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]

ввод элеменетов через консоль (через запятую. использовать метод string.Split())*/
Console.Write("Введите цифры массива через запятую ");
string arr = Console.ReadLine();
string [] ArrayTwo = arr.Split(',');

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
GetArray(size);


if (ArrayTwo.Length != size)
{
    Console.Write($"Массив не из {size} символов");
    return;
}

void GetArray(int array)
{
   
    int[] MyArray = new int[array];
    for (int i = 0; i < ArrayTwo.Length; i++)
    {
        MyArray[i] = Int32.Parse(ArrayTwo[i]);
        
    }
    Console.Write("[{0}]", string.Join(",", MyArray));
}


