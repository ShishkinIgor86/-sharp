//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трехзначное число: ");
int a=Convert.ToInt32(Console.ReadLine());
if (a>99 && a<1000)
{
    Console.WriteLine($"Вторая цифра числа {a} равна: "+ Convert.ToString((a/10)%10));
}
else
{
    Console.WriteLine("Вы ввели не трехзанчное число");
}
// Еще один способ решить эту задачу, с помощью строк
Console.Write("Введите трехзначное число: ");
string chislo=Console.ReadLine();
if (chislo.Length==3)
{
    Console.WriteLine($"Вторая цифра числа {chislo} равна: "+ chislo[1]);
}
else
{
    Console.WriteLine("Вы ввели не трехзанчное число");
}
