// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


﻿int M = 1;
int N = 15;
Console.WriteLine($"Сумма элементов от {M} до {N}: {SumNaturalNumbers(M, N)}");

int SumNaturalNumbers(int M, int N)
{
    if (M == N)
        return M;
    
    return N + SumNaturalNumbers(M, N - 1);
}
