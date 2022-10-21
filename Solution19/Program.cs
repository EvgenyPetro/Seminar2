// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int x = Convert.ToInt32(Console.ReadLine());

bool isPolindrom(int number)
{
    int num = number;
    int revers = 0;
    while (num > 0)
    {
        int endNumber = num % 10;
        revers = revers * 10 + endNumber;
        num = num / 10;
    }
    return (number == revers);
}

if (isPolindrom(x))
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

