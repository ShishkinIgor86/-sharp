// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string rec(int n)
{
    if (n==1)
    {
        return Convert.ToString(n);
    }
    return Convert.ToString(n)+rec(n-1);
}
Console.Write("Введите число N для вывода всех натуральных чисел от N до 1: ");
int n=Convert.ToInt32(Console.ReadLine());
if (n<=0)
{
    Console.Write("Вы ввели не натуральное число.");
}
else
{
    Console.Write($"N={n}->{rec(n)}");
}