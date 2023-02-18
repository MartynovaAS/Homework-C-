// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет



Console.WriteLine("Введите цифру ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 7)
{
    Console.WriteLine("Такого дня нелели нет");
}
else
{
    if (day > 0)
    {
        if (day >= 6)
        {
            Console.WriteLine("Выходной день");
        }
        else
        {
            Console.WriteLine("Рабочий день");
        }
        Console.WriteLine(day);
    }
    else
    {
        Console.WriteLine("Такого дня в неделе нет");
    }

}
