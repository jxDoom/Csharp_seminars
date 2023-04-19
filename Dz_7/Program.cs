// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


//Ввод числа с клавиатуры
int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

// Заполнение матрицы случайными вещественными числами
double[,] DoubleMatrix(int rows, int columns, int minValue, int maxValue)
{
    double[,] matrix = new double[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minValue, maxValue + 1) + rnd.NextDouble();
        }
    }
    return matrix;
}

// Вывод матрицы из вещественных чисел (тип переменной double)
void PrintDoubleMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Solution_47()
{
    int m = SetNumber("rows");
    int n = SetNumber("columns");
    int minValue = SetNumber("min");
    int maxValue = SetNumber("max");
    Console.WriteLine();
    double[,] matrix = DoubleMatrix(m, n, minValue, maxValue);
    PrintDoubleMatrix(matrix);
}


// Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве,
// и возвращает его индексы первого найденого числа или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// Задаём массив случайных чисел
int[,] GetRandomMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, columns];
    var rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

// Вывод матрицы
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Нахождение индекса найденного числа в матрице
(int, int) FindIndexNumber(int[,] matrix)
{
    int find = SetNumber("find");
    int index = -1;
    Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == find)
            {
                Console.Write($"The first number of find is under the matrix index ({i}, {j})");
                return (i, j);
            }
        }
    }
    if (index == -1) Console.WriteLine("There is no such number in the matrix");
    return (-1, -1);
}

void Solution_50()
{
    int rows = SetNumber("rows");
    int columns = SetNumber("columns");
    int minValue = SetNumber("min");
    int maxValue = SetNumber("max");
    Console.WriteLine();
    int[,] matrix = GetRandomMatrix(rows, columns, minValue, maxValue);
    PrintMatrix(matrix);
    Console.WriteLine();
    FindIndexNumber(matrix);
}


// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Нахождение среднего арифметического каждого столбца
void ColumnsArrayAvg(int[,] matrix)
{
    double avg = 0;
    Console.WriteLine("The arithmetic mean of each column of the matrix is: ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        avg = sum / matrix.GetLength(0);
        Console.Write($"{Math.Round(avg, 2)}; ");
    }
}

void Solution_52()
{
    int rows = SetNumber("rows");
    int columns = SetNumber("columns");
    int minValue = SetNumber("min");
    int maxValue = SetNumber("max");
    Console.WriteLine();
    int[,] matrix = GetRandomMatrix(rows, columns, minValue, maxValue);
    PrintMatrix(matrix);
    Console.WriteLine();
    ColumnsArrayAvg(matrix);
}

Start();

void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("47) Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
        Console.WriteLine("50) Задача 50: Напишите программу, которая на вход принимает элемент в двумерном массиве, и возвращает его индексы первого найденого числа или же указание, что такого элемента нет.");
        Console.WriteLine("52) Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
        Console.WriteLine("0) End");

        int numTask = SetNumber("task");

        switch (numTask)
        {
            case 0: return; break;
            case 47: Solution_47(); break;
            case 50: Solution_50(); break;
            case 52: Solution_52(); break;
            default: Console.WriteLine("Error"); break;
        }
    }
}

