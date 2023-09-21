// Задача 54
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



﻿
var array = GenArray();
Console.WriteLine("Исходный массив:");
PrintArray(array);
SortRows(array);
Console.WriteLine("\nУпорядоченный массив:");
PrintArray(array);

int[,] GenArray(int rows = 5, int cols = 6)
{
    Random random = new Random();
    int[,] array = new int[rows, cols];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = random.Next(1, 50);
        } 
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SortRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        // Создаем временный массив для хранения отсортированных элементов строки
        int[] sortedRow = new int[array.GetLength(1)];

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sortedRow[j] = array[i, j];
        }

        // Сортируем временный массив по убыванию
        Array.Sort(sortedRow);
        Array.Reverse(sortedRow);

        // Копируем отсортированные элементы обратно в исходный массив
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = sortedRow[j];
        }
    }
}
