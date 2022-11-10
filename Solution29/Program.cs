//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//    1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//    6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите длину массива: ");
int lengtArray = Convert.ToInt32(Console.ReadLine());

void GetRandomArray(int lengtArray)
{
    Console.Write("[");
    int[] array = new int[lengtArray];

    for (int i = 0; i < lengtArray; i++)
    {
        int randomNumber = new Random().Next();
        array[i] = randomNumber;
        if (i == lengtArray - 1)
        {
            Console.Write(array[i] + "]");
        }
        else
        {
            Console.Write(array[i] + ",");
        }
    }
}

GetRandomArray(lengtArray);

