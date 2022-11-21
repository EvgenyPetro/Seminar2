//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//    m = 3, n = 4.
//
//    0,5 7 -2 -0,2
//    1 -3,3 8 -9,9
//    8 7,8 -7,1 9


double[,] GetRandomArray(int lines, int colums)

{
    int minArrayLimit = -100;
    int maxArrayLimit = 100;
    Random random = new Random();
    double[,] randomArray = new double[lines, colums];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            randomArray[i, j] = random.NextDouble() * (maxArrayLimit - minArrayLimit) + minArrayLimit;
        }
    }

    return randomArray;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(array[i, j], 2)} ");
        }

        Console.WriteLine("");
    }
}


Console.WriteLine("Введите количество строк");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

PrintArray(GetRandomArray(lines, columns));