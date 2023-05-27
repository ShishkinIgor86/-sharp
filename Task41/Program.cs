// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int count_pos(int[] array)
{
    int posit=0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]>0)
        {
            posit+=1;
        }
    }
    return posit;
}

void vivod_arr(int[] arr)
 {
    Console.Write(String.Join(",",arr));
 }

Console.WriteLine("Введите последовательность чисел \n(числа вводятся в одну строку через запятую, Enter окончание ввода):");
int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
vivod_arr(array);
Console.WriteLine($"->{count_pos(array)}");