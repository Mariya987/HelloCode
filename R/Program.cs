﻿/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine("Введите первое число");
string firstNamber = Console.ReadLine();
Console.WriteLine("Введите второе число");
string secondNamber = Console.ReadLine();

int firstNum = int.Parse(firstNamber);
int secondNum = int.Parse(secondNamber);

if (firstNum > secondNum)

    Console.WriteLine($"число {firstNum} является максимальным");

else

    Console.WriteLine($"число {secondNum} является максимальным");
