//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array(int a)
{
    int[] vector=new int[a];
    for (int i=0;i<a;i++)
    {
        vector[i]=new Random().Next(100,1000);
    }
    return vector;
}

void printarray(int[] array)
{
    Console.Write("[");
    Console.Write(String.Join(",",array));
    Console.Write("]");
}

int countChet(int[] array)
{
    int chChet=0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]%2==0)
        {
            chChet+=1;
         }
    }
    return chChet;
}

Console.Write("Введите размерность массива: ");
int a=Convert.ToInt32(Console.ReadLine());
int[] vector=array(a);
printarray(vector);
Console.WriteLine($"->{countChet(vector)}");
