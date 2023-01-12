/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
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

int AkkermanFunction(int m, int n)
{
    {
        if (m > 0)
        {
            if (n > 0)
               return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
            
            else if (n == 0)
                return AkkermanFunction(m - 1, 1);
        }
        else if (m == 0)
        {
            if (n >= 0)
                return n + 1;
        }
        throw new System.ArgumentOutOfRangeException();
    }
}

Console.WriteLine($"{AkkermanFunction(m, n)}");