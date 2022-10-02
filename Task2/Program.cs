/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Введите первое число");
string firstNamber = Console.ReadLine();
Console.WriteLine("Введите второе число");
string secondNamber = Console.ReadLine();
Console.WriteLine("Введите третье число");
string thirdNamber = Console.ReadLine();

int firstNum = int.Parse(firstNamber);
int secondNum = int.Parse(secondNamber);
int thirdNum = int.Parse(thirdNamber);
int max = firstNum;


if (firstNum > max ) max = firstNum;
if (secondNum > max ) max = secondNum;
if (thirdNum > max ) max = thirdNum;

    Console.WriteLine(max);
