Console.Write("Введите 3 числа для отыскания максимального в последовательности \n(числа вводятся в одну строку через запятую):");
string[] mas = Console.ReadLine().Split(',');
int maxch=Convert.ToInt32(mas[0]);
for (int i=0; i<3; i++)
{
   if (Convert.ToInt32(mas[i])>maxch)
   {
    maxch=Convert.ToInt32(mas[i]);
   }
}
Console.WriteLine("Максимальное число в введеной последовательности: "+maxch);