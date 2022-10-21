// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Kube(int N)
{
    for (int i = 1; i< N; i++)
    {
        Console.Write(Math.Pow(i, 3) + ", ");
    }
    Console.Write(Math.Pow(N, 3));
}

Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

Kube(x);