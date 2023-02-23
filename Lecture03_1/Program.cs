// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int sizeNumber, index;


sizeNumber = 5;
int [] numberArr = new int[sizeNumber];
index = 0;
Console.WriteLine("Введите число: ");

while (index < sizeNumber)
{
   int newNumber = Convert.ToInt32(Console.ReadLine());
   numberArr[index] = newNumber;
   index = index + 1;
}
if (numberArr[0] == numberArr[4] || numberArr[1] == numberArr[3])
{
    Console.WriteLine("Данное число: Палиндром");
}
else
{
    Console.WriteLine("Данное число:Не палиндром");
}

