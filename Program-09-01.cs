/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

// Задайте значение N
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
int n = GetNumberFromConsole("Введите число");

string GetNumbers(int n)
{
    if (n == 1)
    {
        return n.ToString();
    }
    else
    {
        return $"{n}," + GetNumbers(n - 1);
    }

}
Console.WriteLine(GetNumbers(n));