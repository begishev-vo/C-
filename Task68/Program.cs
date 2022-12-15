// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

static uint AkkNumber(unit M, unit N)
{
    if (M == 0)
        return N + 1;
    else 
      if ( (N != 0) && (M == 0))
        return AkkNumber(M -1, 1);
    else
        return AkkNumber(M - 1, AkkNumber(M, N-1)); 
}

Console.WriteLine(AkkNumber(1, 2));
Console.WriteLine(AkkNumber(0, 0));

Console.ReadKey();
