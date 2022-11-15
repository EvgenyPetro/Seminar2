//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//которая покажет количество чётных чисел в массиве.
//    [345, 897, 568, 234] -> 2

int CountOfEvenNumbers()
{
    Random random = new Random();
    int[] randomArray = new int [random.Next(3, 10)];
    int countEvenNumbers = 0;
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = random.Next(100, 999);

        if (randomArray[i] % 2 == 0)
        {
            countEvenNumbers++;
        }
    }

    Console.Write($" [{String.Join(",", randomArray)}] ");
    Console.WriteLine();
    return countEvenNumbers;
}


Console.Write($"Count Even Numbers : {CountOfEvenNumbers()}");
