/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.538*/
//D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2)


void GetDistanceBetweenTwoPoints (int firstX, int secondX, int firstY, int secondY, int firstZ, int secondZ)
{
    double result = 0;

    result = Math.Sqrt(Math.Pow(firstX-secondX,2) + Math.Pow(firstY-secondY,2) + Math.Pow(firstZ-secondZ,2));

    Console.WriteLine($"Рассояние между тремя точками {result}");
}
 
GetDistanceBetweenTwoPoints(7,1,-5,-1,0,9);