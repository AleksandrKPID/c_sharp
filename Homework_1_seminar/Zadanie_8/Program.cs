﻿//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

﻿int a = new Random().Next(1,100);
Console.WriteLine(a.ToString());
int b = 1;
while (b < a)
{
    Console.WriteLine(b + 1);
    b += 2;
}