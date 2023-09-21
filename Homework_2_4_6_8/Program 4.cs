//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a = new Random().Next(1,100);
Console.WriteLine(a.ToString());
int b = new Random().Next(1,100);
Console.WriteLine(b.ToString());
int c = new Random().Next(1,100);
Console.WriteLine(c.ToString());

int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);
