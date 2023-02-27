// Напишите метод, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

 int a = 0;
 int b = 0;
Method(a,b);

void Method(int a, int b)
    {
        Console.Write("Введите первое число: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        int method = firstNumber;
        for (int i = 1; i < secondNumber; i++)
        {
            method = method * firstNumber;
        }
        Console.WriteLine($"{firstNumber} в степени {secondNumber} = " + method);
    }


