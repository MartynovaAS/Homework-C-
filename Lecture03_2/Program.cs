// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double[] LenArray(int size)
{
    return new double[size];
}
void FillByUser(double[] array)
{
    int size = array.Length;
    int index = 0;

    while (index < size)
    {
        array[index] = GetNumber("Введите " + index + " элемент: ");
        index++;
    }
}
int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

double Distance(double[] array)
{
    return Math.Sqrt(Math.Pow(array[0], 2) + Math.Pow(array[1], 2) + Math.Pow(array[2], 2));
}
double Summ(double[] array)
{
    return Math.Pow(array[0], 2) + Math.Pow(array[1], 2) + Math.Pow(array[2], 2);
}
double Sqrt(double summ)
{
    return Math.Sqrt(summ);
}
double[] Diff (double [] arrayA, double[] arrayB)
{
    int size = arrayA.Length;
    double[] result = new double [arrayA.Length];
    for(int index = 0; index<size; index ++)
    {
        result[index] = arrayB[index] - arrayA[index];
    }
   return result; 
}

double[] ArrayA = LenArray(3);
FillByUser(ArrayA);
double[] ArrayB = LenArray(3);
FillByUser(ArrayB);
Console.WriteLine("Расстояние между 2мя точками ");
double[] diff = Diff(ArrayA,ArrayB);
double distance = Distance(diff);

Console.WriteLine(distance);
Console.WriteLine("Расстояние между 2мя точками");
