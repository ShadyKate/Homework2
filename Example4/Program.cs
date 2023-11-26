Console.Clear();
Console.WriteLine("Введите любое натуральное число: ");
int Number = int.Parse(Console.ReadLine()!);
if (Number < 10)
Console.WriteLine(Number);
else 
{
    while (Number > 0)
    {
        int result = Number % 10;
        Number = Number / 10;
        if (Number > 0)
        {
            Console.Write(result + ",");
        }
        else
        {
            Console.WriteLine(result);
        }
    }
}