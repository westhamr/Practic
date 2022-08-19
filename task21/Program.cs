Console.Write("Напишите координаты x1 ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Напишите координаты y1 ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Напишите координаты z1 ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Напишите координаты x2 ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Напишите координаты y2 ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Напишите координаты z2 ");
int z2 = int.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между двумя точками в пространстве {distance:f2}");