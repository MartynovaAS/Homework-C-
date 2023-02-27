// Напишите метод, который задаёт массив 
// из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] data = {};
Console.WriteLine("Введите число: ");
int N = 30;
int m = 10;
int [] array = new int[N];
Random rand = new Random();
Console.WriteLine("Исходный массив:");
for (int i = 0; i < array.Length; i++)
{
array[i] = rand.Next(-3, m);
}
int min = array.Min();
Console.WriteLine(String.Join(' ',array));
int[] counter = new int[m+Math.Abs(min)];
for (int i =0; i< array.Length; i++)
{
    counter[array[i] + Math.Abs(min)]++;
}
Console.WriteLine(String.Join(' ',counter));
for (int i = 0; i< counter.Length; i++)
{
    if (counter[i] !=0)
    Console.WriteLine($"{i - Math.Abs(min)} {counter[i]}p");
}
int k = 0;
for (int i = 0; i < counter.Length; i++)
{
    for(int j =0; j < counter[i]; j++)
    {
        array[k] = i - Math.Abs(min);
        k++;
        Console.Write(i - Math.Abs(min) + " ");
    }
}
Console.WriteLine(String.Join(' ', array));