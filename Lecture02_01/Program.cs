// Напишите программу, 
// которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int value = 16;
if (value > 99 || value >= 1000)
{
int result = (value / 10) % 10;
Console.WriteLine(result);
result = (value / 10) - ((value / 10) / 10 * 10);
Console.WriteLine(result);
}
else{
  Console.WriteLine("Число неверное"); 
}