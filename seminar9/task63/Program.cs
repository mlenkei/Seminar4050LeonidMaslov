// Задача 63: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int n = GetNumberFromUser($"Введите число ", "Ошибка ввода!");
string result = GetResult(1, n);
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

string GetResult(int start, int end)
{
    if (start == end) return end.ToString();
    else return start + " " + GetResult(start + 1, end);
}