﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число С: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
        Console.WriteLine($"Мксимальное число: {a}");
    }
    else
    {
        Console.WriteLine($"Максимальное число: {c}");
    }
}
else if (b > c)
{
    Console.WriteLine($"Максимальное число: {b}");
}
else
{
    Console.WriteLine($"Максимальное число: {c}");
}
