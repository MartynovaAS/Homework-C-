// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



int n, index, cube;

n = 0;
Console.WriteLine("Введите N");
n = (int) Convert.ToInt32(Console.ReadLine());
int[] ivi = new int[n];
cube = 0;
index = 0;
while (n > 0)
{
    cube = n * n * n;
    ivi[index] = cube;
    index = index + 1;
    n = n - 1;
}
for (index = index - 1; index >= 0; index--)
{
     Console.Write(ivi[index] + " ");
}
