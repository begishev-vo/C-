// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите число M: ");
// int numberM = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());

int SumNatM_N(int M, int N)
{
    int st = M;
    int finish = N;
    if (M > N)
    {
        st = N;
        finish = M;
    }
    return (finish + st)*(finish - st +1)/2; 
}

int sum_m_n = SumNatM_N(8, 2);
Console.WriteLine($"Сумма чисел:  {sum_m_n}");
