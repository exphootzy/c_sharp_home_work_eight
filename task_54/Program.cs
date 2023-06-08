// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] SortRowsArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(0); k++)
        {
            for (int j = 0; j < array.GetLength(1)- 1 - i; j++)
            {
                if (array[k, j] < array[k, j + 1])
                {
                    (array[k, j], array[k, j + 1]) = (array[k, j + 1], array[k, j]);
                }
            }
        }
    }

    return array;
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
int[,] array_sort = SortRowsArray(array);
System.Console.Write($"Отсортированный по строкам массив: ");
PrintArray(array_sort);