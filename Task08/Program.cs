﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Введите целое число:  ");
// int number = Convert.ToInt32(Console.ReadLine());

// // string str = "4"; 

// int square = number * number; 
// Console.WriteLine($"Квадрат числа {number} = {square}");

Console.WriteLine("Введите целое число:  ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 1; 

while (count <= number)
{
    if (count %2 == 0)
    {
        Console.Write($"{count}   ");
    }
    count++;
} 
