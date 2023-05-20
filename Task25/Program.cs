// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int st(int A, int B)
{
  if (B<0)
  {
    return -1; 
  }
  else if (B==0)
  {
    return 1;
  }
  else
  {
    int pr=1;
    for (int i=1; i<=B;i++)
    {
        pr*=A;
    }
    return pr;
  }
}
Console.WriteLine("Программа на вход получает два числа A и B, \n на выходе вы получаете результат возведения числа A в натуральную степень B, \n если число B является отрицательным, на выходе вы получите значение -1");
Console.Write("A= ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("B= ");
int b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{a},{b}->{st(a,b)}");