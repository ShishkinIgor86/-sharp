Console.Write("Введите число для проверки на четность: ");
int a= Convert.ToInt32(Console.ReadLine());
if (a%2==0)
{
    Console.WriteLine(a+" является четным числом");
}
else 
{
    Console.WriteLine(a+" не является четным числом");
}