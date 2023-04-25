//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int a=Convert.ToInt32(Console.ReadLine());
if (a>99)
{
    int c=a;
    while (c>=1000)
    {
        int b=c/10;
        c=b;
    }
    Console.WriteLine($"Третья цифра введеного числа {a}: " + Convert.ToString(c%10));
}
else
{
    Console.WriteLine("Третьей цифры нет, возможно вы ввели однозначное или двузначное число.");
}
//Второй способ:
Console.Write("Введите число: ");
string s=Console.ReadLine();
if (s.Length>2)
{
    Console.WriteLine($"Третья цифра введеного числа {s}: " + s[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет, возможно вы ввели однозначное или двузначное число.");
}