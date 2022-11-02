
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


// Console.WriteLine("Введите целое число:  ");
// int number = Convert.ToInt32(Console.ReadLine());

// // string str = "4"; 

// int square = number * number; 
// Console.WriteLine($"Квадрат числа {number} = {square}");

Console.WriteLine("Введите три числа:  ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

int maximum = number1;
if (maximum < number2)
{
    maximum = number2; 
    if (maximum < number3)
    {
        Console.WriteLine($"Максимум = {number3} ");
    }
    else
    {
        Console.WriteLine($"Максимум = {number2} ");
    }
}
else
{
    Console.WriteLine($"Максимум = {number1} ");
}