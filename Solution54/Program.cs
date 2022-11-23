//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//    Например, задан массив:
//    1 4 7 2
//    5 9 2 3
//    8 4 2 4
//    В итоге получается вот такой массив:
//    7 4 2 1
//    9 5 3 2
//    8 4 4 2

int[,] SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        SortLinesOfArray(i, array);
    }

    return array;
}

void SortLinesOfArray(int lines, int[,] array)
{
    for (int j = 0; j < array.GetLength(0) - 1; j++)
    {
        for (int k = 0; k < array.GetLength(0) - j - 1; k++)
        {
            int temp = array[lines, k];
            if (array[lines, k] > array[lines, k + 1])
            {
                array[lines, k] = array[lines, k + 1];
                array[lines, k + 1] = temp;
            }
        }
    }
}

int[,] GetRandomArray()
{
    Random random = new Random();
    int lines = random.Next(4, 4);
    int colums = random.Next(4, 4);

    int[,] randomArray = new int[lines, colums];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            randomArray[i, j] = random.Next(1, 99);
        }
    }

    return randomArray;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }

        Console.WriteLine("");
    }
}

int[,] randomArray = GetRandomArray();
PrintArray(randomArray);
Console.WriteLine();
PrintArray(SortArray(randomArray));

