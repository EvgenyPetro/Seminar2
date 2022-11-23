//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//    Например, даны 2 матрицы:
//    2 4 | 3 4
//    3 2 | 3 3
//    Результирующая матрица будет:
//    18  20
//    15 18
//

int[,] GetMultiTwoMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    if (matrixOne.GetLength(1) != matrixTwo.GetLength(0))
    {
        throw new Exception("Число столбцов первой матрицы должно совпадать с числом строк второй матрицы");
    }

    int[,] matrixTree = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];

    for (int k = 0; k < matrixOne.GetLength(0); k++)
    {
        for (int i = 0; i < matrixTwo.GetLength(1); i++)
        {
            int multip = 0;
            for (int j = 0; j < matrixTwo.GetLength(0); j++)
            {
                multip += matrixOne[k, j] * matrixTwo[j, i];
            }

            matrixTree[k, i] = multip;
        }
    }

    return matrixTree;
}

int[,] GetRandomArray(int countLines, int countColums)
{
    Random random = new Random();
    int lines = random.Next(countLines, countLines);
    int colums = random.Next(countColums, countColums);

    int[,] randomArray = new int[lines, colums];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            randomArray[i, j] = random.Next(1, 10);
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


int[,] randomArray1 = GetRandomArray(5, 5);
int[,] randomArray2 = GetRandomArray(5, 10);
PrintArray(randomArray1);
Console.WriteLine();
PrintArray(randomArray2);
Console.WriteLine();


try
{
    PrintArray(GetMultiTwoMatrix(randomArray1, randomArray2));
}
catch (Exception exception)
{
    Console.WriteLine(exception.Message);
}