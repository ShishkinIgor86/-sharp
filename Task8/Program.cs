Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
string chet="";
string chet1="";
//Первый способ вывести все четные числа от 1 до N
for (int i=1; i<=n; i++)
{
    if (i%2==0)
    {
        chet=chet+Convert.ToString(i)+",";
    }
}
Console.WriteLine($"Все четные числа от 1 до {n} : "+chet.TrimEnd(','));
//Второй способ вывести все четные числа от 1 до N
for (int i=1; i<=n/2; i++)
{
    
        chet1=chet1+Convert.ToString(i*2)+",";
}
Console.WriteLine($"Все четные числа от 1 до {n} : "+chet1.TrimEnd(','));