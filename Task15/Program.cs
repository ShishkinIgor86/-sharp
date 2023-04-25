//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите номер интересующего вас дня недели: ");
int a=Convert.ToInt32(Console.ReadLine());
switch (a)
{
    case 1:
     Console.WriteLine("Понедельник - не выходной");
     break;
    case 2:
     Console.WriteLine("Вторник - не выходной");
     break;
    case 3:
     Console.WriteLine("Среда - не выходной");
     break;
    case 4:
     Console.WriteLine("Четверг - не выходной");
     break;
    case 5:
     Console.WriteLine("Пятница - не выходной");
     break;
    case 6:
     Console.WriteLine("Суббота - выходной");
     break;
    case 7:
     Console.WriteLine("Воскресенье - выходной");
     break;
    default:
     Console.WriteLine("Нет такого номера дня недели");
     break;
}
// Второй вариант:
Console.Write("Введите номер интересующего вас дня недели: ");
int den=Convert.ToInt32(Console.ReadLine());
if (den==6 || den==7 )
{
    Console.WriteLine("Выходной");
}
else if (den>0 && den < 6)
{
    Console.WriteLine("Рабочий день");
}
else 
{
    Console.WriteLine("Нет такого номера дня недели");
}