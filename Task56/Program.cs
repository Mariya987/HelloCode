/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/


int[,] RandomNumbers(int m, int n)
{   
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}


int SumStringMatrix(int[,] matrix)
{
    int index = 0;
    int sum = 0;
    int minsum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
            if (sum <= minsum) sum = minsum;
            index = i;        
        }
    }
    return index;            
}
   

int m = GetNumber("Введите количестко строк");
int n = GetNumber("Введите количество столбцов");
int[,] matrix = RandomNumbers(m,n);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой {SumStringMatrix(matrix)}");
