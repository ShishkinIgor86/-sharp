// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
double sum_st=0;
double[] cr_ar= new double[b]; 
int o=0;
while(o<b){
for (int i=0;i<a;i++)
{
   sum_st+=matrix[i,o];
    
}
cr_ar[o]+=sum_st/a;
sum_st=0;
o+=1;
}
Console.Write("Среднее арифметическое каждого столбца: ");
for (int i=0;i<o;i++)
{
    Console.Write(String.Format("{0:0.00}",cr_ar[i])+"; ");
}