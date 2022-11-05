/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

Console.WriteLine("введите количество строк");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите искомое число");
int f = int.Parse(Console.ReadLine());

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 20);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);

for (int j = 0; j < numbers.GetLength(1); j++)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        if(numbers[i,j] == f)
        Console.WriteLine("Искомое число в точке: {0},{1}", i, j);
    }
    Console.WriteLine("Такого числа нет");
}
Console.WriteLine();
PrintArray(numbers);




