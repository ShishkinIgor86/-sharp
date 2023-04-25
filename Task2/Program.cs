Console.Write("Введите певрое число для сравнения: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число для сравнения: ");
int b=Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.Write("max = "+ a+ ", min = " +b);
}
else 
{
     Console.Write("max = "+ b+", min = " +a);
}