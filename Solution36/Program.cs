//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//    [3, 7, 23, 12] -> 19
//    [-4, -6, 89, 6] -> 0

int SumOddElementsInArray()
{
    Random random = new Random();
    int[] randomArray = new int [random.Next(3, 10)];
    int sumOddElements = 0;
    for (int i = 1; i < randomArray.Length; i = i + 2)
    {
        randomArray[i] = random.Next(-100, 100);
        sumOddElements += randomArray[i];
    }

    Console.Write($" [{String.Join(",", randomArray)}] ");
    Console.WriteLine();
    return sumOddElements;
}


Console.Write($"Sum Odd Elements : {SumOddElementsInArray()}");