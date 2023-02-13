// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7; max = 7;
// a = 2; b = 10; max = 10;
// a = -9; b = -3; max = -3

int a, b;

Console.WriteLine("a = Введите число ");
a = 5;
Console.WriteLine("b = Введите число ");
b = 7;
if (a < b)
{
    Console.WriteLine("max = b");
}
else
{
    Console.WriteLine("max = a");
}
if (a > b)
{
    Console.WriteLine("min = b");
}
else
{
    Console.WriteLine("min = a");
}
