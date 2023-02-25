// Напишите программу, которая на вход принимает число и выдает его квадрат(число умноженное 
// на самого себя)

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите число");
string userAnswer = Console.ReadLine();
int numder = Convert.ToInt32(userAnswer);

//более сокращенный вариант
//int numder = Convert.ToInt32(Console.ReadLine();
int rezult = numder * numder;
Console.WriteLine(rezult);