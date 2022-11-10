//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//    452 -> 11
//    82 -> 10
//    9012 -> 12

Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

int GetSum(int number)
{
    int sum = 0;
    int num = number;

    while (num > 0)
    {
        int endNumber = num % 10;
        sum += endNumber;
        num = num / 10;
    }
    return (sum);
}

Console.WriteLine(GetSum(x));
