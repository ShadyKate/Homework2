Console.Clear();
Console.WriteLine("Введите число из отрезка [10;99]: ");
int Number = int.Parse(Console.ReadLine()!);
while (Number < 10 || Number > 99)
{
Console.WriteLine("Вы ошиблись!\nВведите число из отрезка [10;99]: ");
Number = int.Parse(Console.ReadLine()!);
}
int number1 = Number / 10;
int number2 = Number % 10;
if (number1 > number2)
Console.WriteLine($"Наибольшая цифра в числе {Number} это {number1}");
else
Console.WriteLine($"Наибольшая цифра в числе {Number} это {number2}");