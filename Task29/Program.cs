/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]

ввод элеменетов через консоль (через запятую. использовать метод string.Split())*/

Console.WriteLine("Введите элементы массива:");
string[]arrayA = Console.ReadLine().Split(",");

if (arrayA.Length != 8)
{
    int[]digitalArray = new int[arrayA.Length];
    for (int i = 0; i < arrayA.Length; i++)
    {
        digitalArray[i] = Int32.Parse(arrayA[i]);
    }
}
Console.WriteLine("[{0}]", string.Join(", ", arrayA));