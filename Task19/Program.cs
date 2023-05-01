// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
bool crr (string s)//проверка на корректность ввода пользователем числа.
{
string? n=s;
bool result=int.TryParse(n, out var N);
if (result==true){
    if (N>9999 && N<100000){
        return true;
    }
    else
    {
       return false;
    }
}
 else
    {
       return false;
    }
}

void palindrom (string p)
{
int chi=Convert.ToInt32(p);
bool check = true;
if (chi/1000==chi%10*10+chi/10%10)
{
    Console.WriteLine("Это число палиндром");
}
else
{
    Console.WriteLine("Это число не палиндром");
}
}

Console.Write("Введите 5-ти знаачное число: ");
var chislo=Console.ReadLine();
if (crr(chislo))
{
    palindrom(chislo);
} 
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}