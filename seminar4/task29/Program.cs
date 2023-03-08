// Задача 29: Напишите программу,
// которая задаёт массив из 8 элементов и выводит их на экран. 
// Данные вводятся с консоли пользователем

int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int rezult = int.Parse(readInput);
    return rezult;
}

int [] GeneraliteArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random random = new Random();
    for(int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[array.Length - 1]}");
    }
    System.Console.WriteLine("]");
}
int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение, для диапазона случайного числа: ");
int max = Prompt("Конечное значение, для диапазона случайного числа: ");
int[] array = GeneraliteArray(length, min, max);
PrintArray(array);