/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

// Задайте значение M, N
int GetNumberFromConsole(string message)
{
    Console.WriteLine(message);
    int result;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Это не число");
        }
    }
    return result;
}

// Решение задачи с помощью рекурсии
int m = GetNumberFromConsole("Введите число m");
int n = GetNumberFromConsole("Введите число n");

int SumNumbers(int m, int n, int sum)
{
    if (m == n)
    {
        return sum;
    }
    else
    {
        sum += m + 1;
        m = m + 1;
        return SumNumbers(m, n, sum);
    }
}
Console.WriteLine($"{SumNumbers(m, n, m)}");