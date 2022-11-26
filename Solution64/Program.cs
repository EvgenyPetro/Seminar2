// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Задайте значение N");
int natureNumber = Convert.ToInt32(Console.ReadLine());

void WriteNumber(int natureNumber)
{
    if (natureNumber < 1)
    {
        return;
    }

    Console.Write($"{natureNumber} ");
    WriteNumber(--natureNumber);
}

WriteNumber(natureNumber);