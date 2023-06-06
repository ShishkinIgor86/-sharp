// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int su_nat(int m, int n)
{
    if (m==n)
    {
        return m;
    }
    return m+su_nat(m+1,n);
}

Console.Write("Введите число M (начало промежутка суммирования), M - натуральное число: ");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N (окончание промежутка суммирования), N - натуральное число: ");
int n=Convert.ToInt32(Console.ReadLine());
if (m<=0 || n<=0)
{
    Console.Write("Вы ввели не натуральное число.");
}
else
{
    Console.Write($"M={m}; N={n}->{su_nat(m,n)}");
}