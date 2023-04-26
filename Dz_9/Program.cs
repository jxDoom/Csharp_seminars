// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


//Ввод числа с клавиатуры
int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

// Вывод натуральных чисел от M до N рекурсивным методом
void CountFirstLast(int n, int m)
{
    if (n < 0 || m < 0) Console.WriteLine($"Error: numbers {m} or/and {n} - not a natural");
    if (n < m) return;
    Console.Write(n + " ");
    CountFirstLast(n - 1, m);
}

void Solution_64()
{
    int num_M = SetNumber("M");
    int num_N = SetNumber("N");
    Console.WriteLine();
    if (num_N > num_M)
    {
        Console.Write($"Natural numbers between {num_M} and {num_N}: ");
        CountFirstLast(num_N, num_M);
    }
    else Console.WriteLine("Error: enter number N > M");
}


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Нахождение суммы натуральных элементов в промежутке от M до N рекурсивным методом
void SumFirstLast(int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"The sum of natural numbers between M and N equals {sum}");
        return;
    }
    sum += m++;
    SumFirstLast(m, n, sum);
}

void Solution_66()
{
    int num_M = SetNumber("M");
    int num_N = SetNumber("N");
    int sum = 0;
    Console.WriteLine();
    if (num_M < 0 || num_N < 0) Console.WriteLine($"Error: numbers {num_M} or/and {num_N} - not a natural");
    if (num_M < num_N && num_M > 0 && num_N > 0) SumFirstLast(num_M, num_N, sum);
    else Console.WriteLine("Error: enter M < N or not a natural numbers");
}


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// Функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m != 0 && n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}

void Solution_68()
{
    int num_M = SetNumber("M");
    int num_N = SetNumber("N");
    Console.WriteLine();
    if (num_M < 0 || num_N < 0) Console.WriteLine("Error: enter natural numbers");
    else
    {
        Console.WriteLine($"Value of Akkerman function for numbers {num_M} and {num_N} equals {Akkerman(num_M, num_N)}");
    }
}


void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("1. Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");
        Console.WriteLine("2. Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
        Console.WriteLine("3. Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
        Console.WriteLine("0. End");

        int numTask = SetNumber("task");

        switch (numTask)
        {
            case 0: return; break;
            case 1: Solution_64(); break;
            case 2: Solution_66(); break;
            case 3: Solution_68(); break;
            default: Console.WriteLine("Error"); break;
        }
    }
}

Start();