// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Вводим элементы через пробел: ");

int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int number = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        number++;
    }
}
 
Console.WriteLine($" Число элементов больше нуля: {number}");