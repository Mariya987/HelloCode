/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

int[]RandomArray(int arraySize)
{
    int[] array = new int[arraySize];
    Random rnd = new Random();

    for (int i = 0; i < arraySize ; i++)
    {
        array[i] = rnd.Next(10, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

(int, int) GetNegativeAndPositive(int[] array)
{
    int max = array[0];
    int min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
   return (max, min);
}

Console.WriteLine($"Введите размер массива: ");
int arraySize = int.Parse(Console.ReadLine());
int[] arr = RandomArray(arraySize);
PrintArray(arr);

(int GetNumber, int GetNumberTwo) = GetNegativeAndPositive(arr);

Console.WriteLine($"Максимальное значение массива: "+(GetNumber));
Console.WriteLine($"Минимальное значение массива: "+(GetNumberTwo));
Console.WriteLine("Разница максимального и минимального:  "+(GetNumber - GetNumberTwo));