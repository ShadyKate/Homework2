Console.Clear();
Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine()!);
if (Number % 7 == 0 && Number % 23 == 0)
Console.WriteLine($"Число {Number} кратно 7 и 23 одновременно");
else
{
    Console.WriteLine($"Число {Number} не кратно 7 и 23 одновременно");
}
