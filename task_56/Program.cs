// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 20);
    return array;
}


void PrintArray(int[,] array)
{
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
}

int[] GetArraySums(int[,] array)
{
    int[] arraySums = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        arraySums[i] = sum;

    }

    return arraySums;
}

// int[] SortArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         for (int j = 0; j < array.Length - 1 - i; j++)
//         {
//             if (array[j] > array[j + 1])
//             {
//                 (array[j], array[j + 1]) = (array[j + 1], array[j]);
//             }
//         }
//     }
//     return array;
// }
int SearchMinSum(int[] array_sum)
{
    int index = 0;
    int min = int.MaxValue;
    for (int i = 0; i < array_sum.Length; i++)
    {
        if (array_sum[i] < min)
        {
            min = array_sum[i];
            index=i;
        }

    }
    return index;
}

Console.Clear();
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
array = FillArray(array);
System.Console.Write($"Исходный массив: ");
PrintArray(array);
int[] array_sum = GetArraySums(array);
int index = SearchMinSum(array_sum);
System.Console.WriteLine($"Наименьшая сумма элементов строки в строке: {index+1}");
