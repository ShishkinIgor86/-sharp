// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Диапазон [-10, 10]. Обратите внимание на вещественных чисел
// Для примера возьмём диапазон побольше. [3 7 22 2 78] -> 76

double[] array(int a)
{
    double[] vector=new double[a];
    for (int i=0;i<a;i++)
    {
        vector[i]=(new Random().NextDouble())*10-5;
    }
    return vector;
}

void printarray(double[] array)
{
    Console.Write("[");
    Console.Write(String.Join("; ",array));
    Console.Write("]");
}

double difMinMax(double[] array)
{
    double max_el=array[0];
    double min_el=array[0];
    for (int i=0;i<array.Length;i++)
    {
        if (array[i]>max_el)
        {
            max_el=array[i];
        }
        if (array[i]<min_el)
        {
            min_el=array[i];
        }
    }
   //Console.Write($"Максимальный элемент {max_el}, минимальный элемент {min_el}");
    return max_el-min_el;
}

Console.Write("Введите размерность массива: ");
int ch_mas=Convert.ToInt32(Console.ReadLine());
double[] b = array(5);
printarray(b);
Console.Write($"->{difMinMax(b)}");