// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
double ras (int[] arr1, int[] arr2, int t) // на вход метод ras принимает координаты точки А и координаты точки В в виде массива, параметр t отвечает за количество знаков после запятой
{
    double su=0;
    for (int i=0; i<arr1.Length; i++ )
    {
        su+=Math.Pow(arr2[i]-arr1[i],2);
    }
    return Math.Round(Math.Sqrt(su),t);
}
Console.Write("Введите координаты точки A через пробел в 3D: ");
int[] coordA=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
Console.Write("Введите координаты точки B через пробел в 3D: ");
int[] coordB=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
Console.Write("Расстояние между точками A и B в 3D равно " + ras(coordA,coordB,2));
