// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [0,10];
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
  Console.WriteLine($"Значение элемента {n} строки и {m} столбца равно {numbers[n-1, m-1]}");  
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            array [i,j] = new Random().Next(-100,100)/10;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
      Console.Write("[");
      for (int j = 0; j < array.GetLength(1); j++)
      {
      Console.Write(array[i,j] + " ");
      }  
      Console.Write("]");
      Console.Write("");
    }
}