// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк в массиве: ");
int a=Convert.ToInt16(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
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
Console.Write("Введите искомый элемент в массиве: ");
int isk_el=Convert.ToInt32(Console.ReadLine());
int[] posit=new int[a*b];
int p=0;
for (int i=0;i<a;i++)
{
    for (int j=0;j<b;j++)
    {
        if (isk_el==matrix[i,j])
       {
        posit[p]=i;
        posit[p+1]=j;
        p=p+2;
       }
    }
}
Array.Resize(ref posit,p);
if (posit.Length>0)
{
    for (int o=0;o<posit.Length;o+=2){
    Console.WriteLine($"{isk_el}->[{posit[o]},{posit[o+1]}]");
    }
}
else
{
    Console.WriteLine($"{isk_el}->такого числа нет в массиве");
}