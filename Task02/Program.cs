// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите целое число:  ");
// int number = Convert.ToInt32(Console.ReadLine());

// // string str = "4"; 

// int square = number * number; 
// Console.WriteLine($"Квадрат числа {number} = {square}");

Console.WriteLine("Вводим первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вводим второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
{
    Console.WriteLine($"max = {number1}");
}
else
{
    Console.WriteLine($"max = {number2}");
}