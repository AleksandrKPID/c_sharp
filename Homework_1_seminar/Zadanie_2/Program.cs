//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.




int numberA = new Random().Next(1,100);
Console.WriteLine(numberA.ToString());
int numberB = new Random().Next(1,100);
Console.WriteLine(numberB.ToString());

if(numberA > numberB)
{
    Console.WriteLine("max " + (numberA));
}
else
{
    Console.WriteLine("max " + (numberB));
}



