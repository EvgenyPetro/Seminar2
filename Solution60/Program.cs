//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//    Массив размером 2 x 2 x 2
//    66(0,0,0) 25(0,1,0)
//    34(1,0,0) 41(1,1,0)
//    27(0,0,1) 90(0,1,1)
//    26(1,0,1) 55(1,1,1)


void GetRandom3DArray(int x, int y, int z)
{
    if (x * y * z >= 90)
    {
        throw new Exception(
            "X * Y * Z  не должно превышать 90, т.к. уникальных двузначных значений от 10 до 99 равно 90");
    }

    int[,,] random3DArray = new int[x, y, z];
    int[] tempArray = GetUnicArray(random3DArray.Length);
    int elementOfArray = 0;
    for (int i = 0; i < z; i++)
    {
        Console.WriteLine("Sloy " + (i + 1));
        for (int j = 0; j < x; j++)
        {
            for (int k = 0; k < y; k++)
            {
                random3DArray[j, k, i] = tempArray[elementOfArray++];
                Console.Write($"{random3DArray[j, k, i]} ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}

int[] GetUnicArray(int lenghtArray)
{
    Random random = new Random();
    int[] tempArray = new int[lenghtArray];

    for (int i = 0; i < lenghtArray; i++)
    {
        int element = random.Next(10, 100);
        if (!Contains(tempArray, element))
        {
            tempArray[i] = element;
        }
        else
        {
            i--;
        }
    }

    return tempArray;
}

bool Contains(int[] array, int element)
{
    foreach (var e in array)
    {
        if (e == element)
        {
            return true;
        }
    }

    return false;
}

try
{
    GetRandom3DArray(4, 4, 5);
}
catch (Exception exception)
{
    Console.Write(exception.Message);
}

