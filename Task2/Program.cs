// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();

Console.WriteLine("Ведите первое число в координатах первой точки: ");
int x1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Ведите второе число в координатах первой точки: ");
int y1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Ведите третье число в координатах первой точки: ");
int z1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Ведите первое число в координатах второй точки: ");
int x2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Ведите второе число в координатах второй точки: ");
int y2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Ведите третье число в координатах второй точки: ");
int z2 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine(Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2)));