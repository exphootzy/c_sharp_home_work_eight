// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] FillArray(int[,,] array)
{
    Random rnd = new Random();
    int temp;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                temp = rnd.Next(20);
                while (SearchDublicate(temp, array))
                {
                    temp = rnd.Next(20);
                }
                array[i, j, k] = temp;
                // array[i, j, k] = new Random().Next(2, 5);
            }

        }
    }

    return array;
}

bool SearchDublicate(int tmp, int[,,] array)
{
    foreach (var item in array)
    {
        if (item == tmp)
        {
            return true;
        }
    }
    return false;
}


void PrintArray(int[,,] array)
{
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i, j, k],3} ({i} | {j} | {k})   ");
                System.Console.WriteLine();
            }

        }
    }
}

Console.Clear();

int[,,] arrayThreeD = new int[2, 2, 2];
arrayThreeD = FillArray(arrayThreeD);
PrintArray(arrayThreeD);
