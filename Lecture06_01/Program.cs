// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через запяую: ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int summ = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        summ++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {summ}");

int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',');
        {
            count++;
        }
    }

    int[] numbers = new int[count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = " ";

        while (input [i] != ',')
        {
            if(i != input.Length - 1)
            {
                temp += input [i].ToString();
                break;
            }
            else
            {
                temp += input [i].ToString();
                i++;
            }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("] ");
}
