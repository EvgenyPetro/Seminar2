//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

void Kube(int a, int b)
{
    Console.Write(Math.Pow(b, a));
}

Console.WriteLine("Введите первое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int a = Convert.ToInt32(Console.ReadLine());

Kube(a, b);