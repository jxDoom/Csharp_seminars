//Start();

void Start()
{
    int rows = SetNumber("rows");
    int columns = SetNumber("columns");

    int[,] matrix = GetRandomMatrix(rows, columns, 10, 99);
    PrintMatrix(matrix);
}


int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetRandomMatrix(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];

    var rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(min, max + 1);
        }
    }
    return array;
}

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


// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

void SumMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
}

void Solution_38()
{
    int m = 3;
    int n = 4;
    int[,] matrix = GetRandomMatrix(m, n, 0, 10);
    SumMatrix(matrix);
    PrintMatrix(matrix);
}

//Solution_38();

// Задача 49: Задайте двумерный массив.
// Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

void SqrEvenIndexMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] = Convert.ToInt32(Math.Pow(matrix[i, j], 2));
        }
    }
}

void Solution_39()
{
    int rowe = 6;
    int columns = 6;
    int[,] matrix = GetRandomMatrix(rowe, columns, 0, 10);
    PrintMatrix(matrix);
    Console.WriteLine();
    SqrEvenIndexMatrix(matrix);
    PrintMatrix(matrix);
}

//Solution_39();

// Задача 51: Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int SumDiagonalMatrix(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) sum += matrix[i, j];
        }
    }
    Console.WriteLine($"Сумма элементов массива главной диагонали = {sum}");
    return sum;
}

void Solution_51()
{
    int rowe = 5;
    int columns = 5;
    int[,] matrix = GetRandomMatrix(rowe, columns, 0, 10);
    PrintMatrix(matrix);
    Console.WriteLine();
    SumDiagonalMatrix(matrix);
}

Solution_51();