//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//    [3 7 22 2 78] -> 76

int DiffBetweenMaxMinArrayElements()
{
    Random random = new Random();
    int[] randomArray = new int [random.Next(3, 10)];
    int max = Int32.MinValue;
    int min = Int32.MaxValue;
    int diffBetweenMaxMinArrayElements = 0;
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = random.Next(-100, 100);
        if (randomArray[i] > max)
        {
            max = randomArray[i];
        }
        if (randomArray[i] < min)
        {
            min = randomArray[i];
        }
    }

    diffBetweenMaxMinArrayElements = max - min;

    Console.Write($" [{String.Join(",", randomArray)}] ");
    Console.WriteLine();
    return diffBetweenMaxMinArrayElements;
}

Console.WriteLine(DiffBetweenMaxMinArrayElements());
