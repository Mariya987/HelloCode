/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

void CubeTable(int number)
{
    for (int i = 1; i <= number; i++)
    {
        double square = Math.Pow(i,3);
        Console.Write($"{square}, ");
    }
}

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
CubeTable(number);