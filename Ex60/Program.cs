// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


﻿int[, ,] array = GenerateArray();
PrintArray(array);

int[,,] GenerateArray()
{
    Random random = new Random();
    int[,,] array = new int[3, 3, 3];
    bool[] usedNumbers = new bool[100];

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            for (int k = 0; k < 3; k++)
            {
                int randomNumber;
                do
                {
                    randomNumber = random.Next(10, 100);
                } while (usedNumbers[randomNumber - 10]);

                array[i, j, k] = randomNumber;
                usedNumbers[randomNumber - 10] = true;
            }
        }
    }

    return array;
}

void PrintArray(int[, ,] array)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine($"{array[i, j, k]}({i}, {j}, {k})");
            }
        }
    }
}
