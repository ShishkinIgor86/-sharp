// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int acr(int m, int n)
{
    if (m==0)
    {
        return n+1;
    }
    else if (m>0 && n==0) 
    {
        return acr(m-1,1);
    }
    return acr(m-1, acr(m,n-1));
}

Console.Write("Введите первое не отрицательное число M для функции Аккермана: ");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе не отрицательное число N для функции Аккермана: ");
int n=Convert.ToInt32(Console.ReadLine());
if (m<0 || n<0)
{
    Console.Write("Вы ввели отрицательное число.");
}
else
{
   Console.Write( $"m = {m}, n = {n} -> A(m,n) = {acr(m,n)}");
}