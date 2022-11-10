//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

void Exponentiation(int a, int b)
{
    int sum = b;
    for (int i = 1; i < a; i++)
    {
        sum *= b;
    }
    Console.Write(sum);
}

Console.WriteLine("Введите первое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int a = Convert.ToInt32(Console.ReadLine());

Exponentiation(a, b);