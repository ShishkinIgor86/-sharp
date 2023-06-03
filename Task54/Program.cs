// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк в матрице: ");
int a=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите количество столбцов в матрице: ");
int b=Convert.ToInt16(Console.ReadLine());
int[,] matrix= new int[a,b];
for (int i=0;i<a;i++)
{
    for (int j=0;j<b;j++)
    {
        matrix[i,j]=new Random().Next(-20,21);
        Console.Write(matrix[i,j]+" ");
    }
    Console.WriteLine();
}
   Console.WriteLine("В итоге получается вот такой массив:");
int[] ma_el= new int[b];
for (int i=0;i<a;i++)
{
    for (int j=0;j<b;j++)
    {
        ma_el[j]=matrix[i,j];           
    }
    Array.Sort(ma_el);
    Array.Reverse(ma_el);
    for (int j=0;j<b;j++)
    {
        matrix[i,j]=ma_el[j];           
    }
    Console.WriteLine(String.Join(" ", ma_el));
}

 Console.WriteLine("В итоге получается вот такой массив:");
 for (int i=0;i<a;i++)
{
    for (int j=0;j<b;j++)
    {
        Console.Write(matrix[i,j]+" ");
    }
    Console.WriteLine();
}
 
  