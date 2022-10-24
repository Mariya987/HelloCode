/*Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/


int[]RandomArray(int arraySize)
{
     int[] array = new int[arraySize];
     Random rnd = new Random();

     for (int i = 0; i < arraySize ; i++)
     {
         array[i] = rnd.Next(-10, 100);
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
    int summ = 0;
    int newArray = array.Length;
    for (int i = 0; i < newArray; i++)
    {
        if((array[i] % 2) != 0)
        {
           summ += array[i];
        }
    }
   return summ;
}

Console.WriteLine($"Введите размер массива: ");
int arraySize = int.Parse(Console.ReadLine());
int[] arr = RandomArray(arraySize);
PrintArray(arr);
int positiveCount = GetPrivate(arr);
Console.WriteLine($"Сумма нечетных чисел: {positiveCount}");