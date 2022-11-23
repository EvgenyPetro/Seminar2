//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//    Например, задан массив:
//    1 4 7 2
//    5 9 2 3
//    8 4 2 4
//    5 2 6 7
//    Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int GetNumberLine(int[,] array)
{
    int line = 0;
    int minSum = Int32.MaxValue;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumCiycl = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumCiycl += array[i, j];
        }

        if (minSum > sumCiycl)
        {
            minSum = sumCiycl;
            line = i+1;
        }
    }
    return line;
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

int[,] randomArray=GetRandomArray();
PrintArray(randomArray);
Console.WriteLine();

Console.Write(GetNumberLine(randomArray));