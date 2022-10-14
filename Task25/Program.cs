/*Напишите цикл, который принимает на вход два числа
 (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

void Exponentiation(int namberA, int namberB)
{
    double result = 0;

    result = Math.Pow(namberA, namberB);
    Console.WriteLine($"число {namberA} возведенное в степень {namberB} -> {result}");
}
Exponentiation(2, 4);