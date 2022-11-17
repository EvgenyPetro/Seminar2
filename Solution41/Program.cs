//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//    0, 7, 8, -2, -2 -> 2
//    1, -7, 567, 89, 223-> 4

Console.WriteLine("Введите числа через запятую:");
string? numbers = Console.ReadLine();


int GetPositiveCountOfNumbers(string stringNumbers)
{
    string[] stringArray = stringNumbers.Split(",", StringSplitOptions.RemoveEmptyEntries);
    int positivCount = 0;

    try
    {
        foreach (var t in stringArray)
        {
            int number = Convert.ToInt32(t);
            if (number > 0)
            {
                positivCount++;
            }
        }
    }
    catch
    {
        throw new Exception("Должны быть введены только целые числа, (ошибка преобразования):");
    }

    return positivCount;
}

try
{
    if (numbers != null) Console.WriteLine($"Чисел больше нуля: {GetPositiveCountOfNumbers(numbers)}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}



