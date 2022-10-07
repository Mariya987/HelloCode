/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.WriteLine("введите число");
int someNumber = int.Parse(Console.ReadLine());
string anyNumberText = Convert.ToString(someNumber);

if (someNumber > 3)
{
   Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else
{
   Console.WriteLine($"нет третьего числа");
}   

    