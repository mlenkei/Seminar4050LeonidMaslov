// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n = GetNumberFromUser($"Введите число ", "Ошибка ввода!");
string result = GetResult(n, 1);
Console.Write(result);

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

string GetResult(int end, int start)
{
    if (end == start) return start.ToString();
    else return end + " , " + GetResult(end - 1, start);
}