// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] numbers = CreateArray(GetNumber("Введите размер массива"));
FillArray(numbers);
PrintArray(numbers);
Counter(numbers);
int summ = Summ(numbers);
Console.WriteLine(summ);

int[] CreateArray(int size)
{
    return new int[size];
}
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1000);
    }
}

int GetNumber(string massange)
{
    Console.WriteLine(massange);
    Convert.ToInt32(Console.ReadLine());
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}
int Counter(int[] array)
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
int Summ(int[] array)
{
    int summ = 0;
    for (int index = 0; index < array.Length; index += 2)
    {
        summ = summ + array[index];
    }
    return summ;
}
