/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/


//печатаем массив, который рендомно задался

//определяем длину массива 
int[]RandomArray(int arraySize)
{
     int[] array = new int[arraySize];
     Random rnd = new Random();

     for (int i = 0; i < arraySize ; i++)
     {
         array[i] = rnd.Next(100,1000);
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

int GetPrivate(int[] array)
{
    int count = 0;
    int newArray = array.Length;
    for (int i = 0; i < newArray; i++)
    {
        if((array[i] % 2) == 0)
        {
           count++;
        }
    }
   return count;
}

Console.WriteLine($"Введите размер массива: ");
int arraySize = int.Parse(Console.ReadLine());
int[] arr = RandomArray(arraySize);
PrintArray(arr);
int positiveCount = GetPrivate(arr);
Console.WriteLine($"Колличество положительных чисел: {positiveCount}");