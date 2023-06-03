// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк в 1 матрице: ");
int a1=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите количество столбцов в 1 матрице: ");
int b1=Convert.ToInt16(Console.ReadLine());
int[,] matrix1= new int[a1,b1];
for (int i=0;i<a1;i++)
{
    for (int j=0;j<b1;j++)
    {
        matrix1[i,j]=new Random().Next(-20,21);
        Console.Write(matrix1[i,j]+" ");
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк во 2 матрице: ");
int a2=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите количество столбцов во 2 матрице: ");
int b2=Convert.ToInt16(Console.ReadLine());
int[,] matrix2= new int[a2,b2];
for (int i=0;i<a2;i++)
{
    for (int j=0;j<b2;j++)
    {
        matrix2[i,j]=new Random().Next(-20,21);
        Console.Write(matrix2[i,j]+" ");
    }
    Console.WriteLine();
}

if (b1!=a2)
{
    Console.WriteLine("Матрицу 1 можно умножить на матрицу 2 только в том случае, если число столбцов матрицы 1 равняется числу строк матрицы 2.\nМатрицы, для которых данное условие не выполняется, умножать нельзя.");
}
else
{
int[,] res_matr=new int[a1,b2];

for (int i=0;i<a1;i++)
{
    for (int j=0;j<b2;j++)
    {
        int  t_z=0;
       for (int k=0;k<b1;k++)
       {
        t_z+=matrix1[i,k]*matrix2[k,j];
       }
        res_matr[i,j]=t_z;
    }
    
}
Console.WriteLine("Результирующая матрица будет:");
  for (int i=0;i<a1;i++)
{
    for (int j=0;j<b2;j++)
    {
       Console.Write(res_matr[i,j]+" ");
    }
   Console.WriteLine();
}
}