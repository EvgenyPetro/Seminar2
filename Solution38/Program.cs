//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//    [3 7 22 2 78] -> 76

double DiffBetweenMaxMinArrayElements()
{
    Random random = new Random();
    double[] randomArray = new double [random.Next(3, 10)];
    double max = Double.MinValue;
    double min = Double.MaxValue;
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = random.NextDouble() * (100 + 100) - 100;
        if (randomArray[i] > max)
        {
            max = randomArray[i];
        }
        else if (randomArray[i] < min)
        {
            min = randomArray[i];
        }
    }

    double diffBetweenMaxMinArrayElements = max - min;

    Console.Write($" [{String.Join(",", randomArray)}] ");
    Console.WriteLine();
    return diffBetweenMaxMinArrayElements;
}

Console.WriteLine(DiffBetweenMaxMinArrayElements());
