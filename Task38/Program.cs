// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i =0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1); 
    }

    return array;
}

void PrintArray (double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length -1) 
        Console.Write($"{array[i]};  ");
        else Console.Write($"{array[i]}");
    }


    Console.WriteLine("]");
}

double GetSubMinMaxElement(double[] array)
{
    double MiN = array[0];
    double MaX = array[0];
    // double SuB = 0; 

    for (int i = 0; i < array.Length; i++)
    {
        MaX = array.Max();
        MiN = array.Min();
    }
    Console.WriteLine($"max = {MaX}, min = {MiN}, diferent = {Math.Round(Math.Abs(MaX-MiN),1)}");
    return MaX-MiN; 
}



double[] arr = CreateArrayDouble(4, -99, 99);
PrintArray(arr);
GetSubMinMaxElement(arr);