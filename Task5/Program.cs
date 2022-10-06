/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

void Getnumber (int number)
{
     int number2 = number%100;
     int number3 = number2/10;
     
     Console.WriteLine($"второе число {number3}");  
}
Getnumber(918);