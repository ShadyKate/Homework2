Console.Clear();
Console.WriteLine ("Введите координату X: ");
int X = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите координату Y: ");
int Y = int.Parse(Console.ReadLine()!);
while (X == 0 || Y == 0)
{
    Console.WriteLine("Координаты не должны равняться нулю!\nИзмените координаты!!");
    Console.WriteLine ("Введите координату X: ");
    X = int.Parse(Console.ReadLine()!);
    Console.WriteLine ("Введите координату Y: ");
    Y = int.Parse(Console.ReadLine()!);
}
if (X > 0 && Y > 0)
Console.WriteLine($"Точка с координатами ({X}; {Y}) лежит в первой координатной четверти");
if (X < 0 && Y > 0)
Console.WriteLine($"Точка с координатами  ({X}; {Y}) лежит во второй координатной четверти");
if (X < 0 && Y < 0)
Console.WriteLine($"Точка с координатами ({X}; {Y}) лежит в третьей координатной четверти");
if (X > 0 && Y < 0)
Console.WriteLine($"Точка с координатами ({X}; {Y}) лежит в четвёртой координатной четверти");

