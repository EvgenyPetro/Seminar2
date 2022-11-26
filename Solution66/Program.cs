// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Задайте значение M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение N");
int N = Convert.ToInt32(Console.ReadLine());

int SumNaturalElement(int M, int N)
{
    if (M > N)
    {
        throw new Exception("Число M должно быть меньше числа N");
    }
    else if (M == N)
    {
        return 0;
    }
    return SumBetweenElement(M, N);
}

int SumBetweenElement(int natureNumber, int N)
{
    if (M >= N)
    {
        return N;
    }
    return N + SumBetweenElement(M, --N);
}


try
{
    Console.WriteLine($"Sum = {SumNaturalElement(M, N)}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}