// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк в матрице: ");
int a=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите количество столбцов в матрице: ");
int b=Convert.ToInt16(Console.ReadLine());
double[,] matrix= new double[a,b];
for (int i=0;i<a;i++)
{
    for (int j=0;j<b;j++)
    {
        matrix[i,j]=new Random().Next(-20,21)*0.1;
    }
}
for (int i=0;i<a;i++)
{
    for (int j=0;j<b;j++)
    {
        Console.Write(String.Format("{0:0.0}", matrix[i,j])+" ");
    }
    Console.WriteLine();
}
