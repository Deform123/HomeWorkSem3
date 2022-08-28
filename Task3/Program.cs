// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"Вы ввели число: {num}. ");

int count = 1;
while (num > 0 && count <= num)
{
    Console.WriteLine($"Куб числа {count} - {Math.Pow(count, 3)}");
    count++;
}
while (num < 0 && count >= num)
{
    Console.WriteLine($"Куб числа {count} - {Math.Pow(count, 3)}");
    count--;
}