// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке 
//от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("EX_64");
Console.Write("Enter number > 0 to see all numbers between number and 0: ");
int input;
if (!int.TryParse(Console.ReadLine(), out input) || input <= 0)
{
    Console.WriteLine("Invalid input. Please enter a positive integer.");
}
else
{
    Console.WriteLine(NumbersToN(input));
}

string NumbersToN(int n)
{
    if (n == 0 || n < 0)
    {
        return String.Empty;
    }
    else
    {
        return $"{n} " + NumbersToN(n - 1);
    }
}