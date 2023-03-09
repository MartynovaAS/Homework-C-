// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int b = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[a,b];
FillArrayRandomNumbers(numbers);

for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
     avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / a;
    Console.Write(avarage + "; ");
}
 Console.WriteLine();
 PrintArray(numbers);

 void FillArrayRandomNumbers(int[,] array)
 {
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++) 
       {
        array[i, j] = new Random().Next(0,10);
       }
    }
 }

 void PrintArray(int[,] array)
 {
    for (int i = 0; i < array.GetLength(0); i++)
    {
       Console.Write("[ ");
       for (int j = 0; j < array.GetLength(1); j++)
       {
        Console.Write(array[i, j] + " ");
       }
       Console.Write("] ");
       Console.Write("");
    }
 }