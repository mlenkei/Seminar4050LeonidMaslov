// Задача 65: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


Console.Clear();
int m = GetNumberFromUser($"Введите число ", "Ошибка ввода!");  //  вызов метода
int n = GetNumberFromUser($"Введите число ", "Ошибка ввода!");  //  вызов метода
string result = GetResult(m, n);
Console.Write($"M = {m}; N = {n} -> {result}");


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

string GetResult(int m, int n)
{
    if (m == n) return n.ToString();
    else return m + " " + GetResult(m +1, n);
}