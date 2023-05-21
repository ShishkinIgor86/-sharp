// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

void vivod_arr(int[] arr)
 {
     Console.Write("[");
     Console.Write(String.Join(",",arr));
     Console.Write("]");
 }

int[] mas=Console.ReadLine().Split(',').Select(int.Parse).ToArray();
vivod_arr(mas);