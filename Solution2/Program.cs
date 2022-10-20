Console.Write("Введите трехзначное число: ");
String numberA = Console.ReadLine();


char[] characters = numberA.ToCharArray();

try
{
    Console.WriteLine(characters[2]);
}
catch (IndexOutOfRangeException)
{
    Console.Write("третьей цифры нет");
}
