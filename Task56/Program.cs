// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
int[] summ=new int[a];
int ch=0;
for (int i=0;i<a;i++)
{
    for (int j=0;j<b;j++)
    {
        ch+=matrix[i,j];
    }
    summ[i]=ch;
    ch=0;
}
int m_el=summ[0];
int i_m_el=0;
for (int i=0;i<a;i++)
{
    if (m_el>summ[i])
    {
       i_m_el=i;
       m_el=summ[i];
    }
}
Console.Write($"Номер строки с наименьшей суммой элементов: {i_m_el+1} строка и равна {m_el}");