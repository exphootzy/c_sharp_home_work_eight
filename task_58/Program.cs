// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(2, 5);
    return array;
}


void PrintArray(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
}

int[,] ArrayMultiplication(int[,] arrayOne, int[,] arrayTwo)
{
    int [,] arrayMultiplication = new int[arrayOne.GetLength(0),arrayTwo.GetLength(1)];

 for (int i = 0; i < arrayOne.GetLength(0); i++)
            {
                for (int j = 0; j < arrayTwo.GetLength(1); j++)
                {
                    for (int k = 0; k < arrayTwo.GetLength(0); k++)
                    {
                        arrayMultiplication[i,j] += arrayOne[i,k] * arrayTwo[k,j];
                    }
                }
            }
return arrayMultiplication;
}

Console.Clear();
int[,] array = new int[2, 2];

System.Console.WriteLine($"Первый массив: ");
int[,] arrayOne = FillArray(array);
PrintArray(arrayOne);

System.Console.WriteLine($"Второй массив: ");
int[,] arrayTwo = FillArray(array);
PrintArray(arrayTwo);

System.Console.WriteLine($"Произведение массивов: ");
int[,] arrayMultiplication = ArrayMultiplication(arrayOne, arrayTwo);
PrintArray(arrayMultiplication);

