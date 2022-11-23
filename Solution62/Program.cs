//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//    Например, на выходе получается вот такой массив:
//    01 02 03 04
//    12 13 14 05
//    11 16 15 06
//    10 09 08 07

void PrintSpiral(int lines, int colums)
{
    int[,] matrix = new int[lines, colums];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write((matrix[i, j] = 0) + " ");
        }

        Console.WriteLine();
    }

    Console.WriteLine();

    int posX = 0;
    int posY = -1;
    int transitionLines = 0;
    int transitionColums = 1;
    int e = 1;
    while (e <= lines*colums)
    {
        if (0 <= posX + transitionLines && posX + transitionLines < lines && 0 <= posY + transitionColums && posY + transitionColums < colums &&
            matrix[posX + transitionLines, posY + transitionColums] == 0)
        {
            posX += transitionLines;
            posY += transitionColums;
            matrix[posX, posY] = e;
            e += 1;
        }
        else if (transitionColums == 1)
        {
            transitionColums = 0;
            transitionLines = 1;
        }
        else if (transitionLines == 1)
        {
            transitionLines = 0;
            transitionColums = -1;
        }
        else if (transitionColums == -1)
        {
            transitionColums = 0;
            transitionLines = -1;
        }
        else
        {
            transitionLines = 0;
            transitionColums = 1;
        }
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:00}  ");
        }

        Console.WriteLine();
    }
}

PrintSpiral(9,10);