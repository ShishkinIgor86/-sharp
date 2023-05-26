// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] array(int a, int minGr, int maxGr)
{
    int[] vector=new int[a];
    for (int i=0;i<a;i++)
    {
        vector[i]=new Random().Next(minGr,maxGr+1);
    }
    return vector;
}

int sumNechet(int[] array)
{
    int sumNct=0;
    for (int i=0; i<array.Length;i++)
    {
        if ((i+1)%2!=0)
        {
            sumNct+=array[i];
        }
    }
    return sumNct;
}

void printarray(int[] array)
{
    Console.Write("[");
    Console.Write(String.Join(",",array));
    Console.Write("]");
}
Begin:
Console.Write("Введите размерность массива:");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Нижнюю границу генерирования элементов:");
int b=Convert.ToInt32(Console.ReadLine());
Console.Write("Верхнюю границу генерирования элементов:");
int c=Convert.ToInt32(Console.ReadLine());
if (b>c)
{
    Console.WriteLine("Нижняя граница больше верхней, попробуйте снова");
    goto Begin; //Знаю, что не желательно использование безусловного перехода goto, но пока не придумал ничего лучше.
}
else
{
    int [] vector=array(a,b,c);
    printarray(vector);
    Console.Write($"->{sumNechet(vector)}");
}