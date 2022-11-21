//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//    Например, задан массив:
//    1 4 7 2
//    5 9 2 3
//    8 4 2 4
//    17 -> такого числа в массиве нет

int GetElement(int positionX, int positionY, int[,] array)
{
    if (positionX > array.GetLength(0) - 1 || positionY > array.GetLength(1) - 1)
    {
        throw new Exception("Позиция элемента за пределами массива");
    }

    return array[positionX, positionY];
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

Console.WriteLine("Введите строку искомого елемента");
int positionX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец искомого елемента");
int positionY = Convert.ToInt32(Console.ReadLine());

try
{
    Console.WriteLine(GetElement(positionX, positionY, randomArray));
}
catch (Exception)
{
    Console.WriteLine("Позиция элемента за пределами массива");
}