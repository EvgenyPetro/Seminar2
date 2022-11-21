//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//
//Например, задан массив:
//    1 4 7 2
//    5 9 2 3
//    8 4 2 4
//    Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void GetColumnAverege(int[,] randomArray)
{
    double[] columAverage = new double[randomArray.GetLength(1)];
    for (int j = 0; j < randomArray.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < randomArray.GetLength(0); i++)
        {
            sum += randomArray[i, j];
        }
        columAverage[j] = Math.Round(sum / randomArray.GetLength(0), 2);
    }

    Console.WriteLine($"{String.Join("; ", columAverage)}");
}


int[,] GetRandomArray()
{
    Random random = new Random();
    int lines = random.Next(3, 10);
    int colums = random.Next(3, 10);

    int[,] randomArray = new int[lines, colums];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            randomArray[i, j] = random.Next(-100, 100);
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
GetColumnAverege(randomArray);