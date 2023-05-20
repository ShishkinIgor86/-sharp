// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int su_ch(int a)
{
    int s_ch=0;
    while (a>0)
    {
        int b=a%10;
        s_ch+=b;
        a/=10;
    }
    return s_ch;
}
Console.WriteLine("---------------------");
int A=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("---------------------");
Console.WriteLine($"{A}->{su_ch(A)}");
Console.WriteLine("---------------------");