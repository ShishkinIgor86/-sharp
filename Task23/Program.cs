// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
void Cubs(int a)// возведение в куб чисел от 1 до N
{
int s=a;
for (int i=1; i<s; i++)
        {
            Console.Write(Math.Pow(i,3)+", ");
        }
            Console.WriteLine(Math.Pow(s,3)+".");
}

void crr(string s) //Проверка на корректность введенного значения
{
string? n=s;
bool result=int.TryParse(n, out var N);
if (result==true){
    if (N>0){
        Console.Write($"Кубы чисел от 1 до {N}: ");
        Cubs(N);   
        Console.WriteLine("Работа программы завершена");
    }
    else
    {
        Console.WriteLine("Вы ввели отрицательное цисло");
        Console.WriteLine("Работа программы завершена");
    }
}
else 
{
    Console.WriteLine("Вы ввели либо не натуральное число, либо символ");
    Console.WriteLine("Работа программы завершена");
}

}

Console.Write("Введитен число N до которого необходимо вывести кубы числе: ");
var vpr=Console.ReadLine();
crr(vpr);
