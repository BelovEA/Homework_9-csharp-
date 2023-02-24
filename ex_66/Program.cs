// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("ex_66");

int SumOfElMToN(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    else
    {
        return m + SumOfElMToN(m + 1, n);
    }
}

Console.WriteLine("Enter two integers m and n, with m < n:");
int m, n;
if (!int.TryParse(Console.ReadLine(), out m) || !int.TryParse(Console.ReadLine(), out n) || m >= n)
{
    Console.WriteLine("Invalid input. Please enter two valid integers with m < n.");
}
else
{
    Console.WriteLine("Sum of numbers between m and n is: " + SumOfElMToN(m, n));
}