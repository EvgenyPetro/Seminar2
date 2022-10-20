Console.Write("Введите трехзначное число: ");

try
{
    String? numberA = Console.ReadLine();
    if (numberA != null)
    {
        char[] characters = numberA.ToCharArray();
        Console.WriteLine(characters[1]);
    }
}
catch {
    Console.WriteLine("Error programm");
}




