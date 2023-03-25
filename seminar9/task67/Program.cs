// Задача 67: Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
int n = GetNumberFromUser($"Введите число ", "Ошибка ввода!");  //  вызов метода
int result = GetResult(n);
Console.Write($"{n} -> {result}");


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

int GetResult(int n)
{
    if (n == 0) return 0;
    else
    {
        
        GetResult(n - 1);
        return n%10 + GetResult(n/10);
    }
}