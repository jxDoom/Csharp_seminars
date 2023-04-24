// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


//Ввод числа с клавиатуры
int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

// Задаём двумерный массив случайных чисел
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

// Сортировка строк матрицы пузырьком по убыванию
int[,] DescendSortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j] < matrix[i, k])
                {
                    int tmp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = tmp;
                }
            }
        }
    }
    return matrix;
}

void Solution_54()
{
    int rows = SetNumber("rows");
    int columns = SetNumber("columns");
    int min = SetNumber("min value");
    int max = SetNumber("max value");
    int[,] matrix = GetRandomMatrix(rows, columns, min, max);
    PrintMatrix(matrix);
    Console.WriteLine();
    DescendSortMatrix(matrix);
    PrintMatrix(matrix);
}


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// Нахождение суммы каждой строки матрицы и заполнение полученных результатов в новый массив
int[] SumRowsMatrix(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    int index = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[index] += matrix[i, j];
        }
        index++;
    }
    return array;
}

// Вывод одномерного массива
void PrintArray(int[] array)
{
    Console.Write("[" + string.Join("; ", array) + "]");
    Console.WriteLine();
}

// Поиск строк(-и) с наименьшей суммой элементов
void CompareResult(int[] array)
{
    int min = array[0];
    int position = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            position = i;
        }
    }
    Console.Write("The row(-s) ");

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == min)
        {
            position = i;
            Console.Write($"{position + 1}, ");
        }
    }
    Console.WriteLine($"with the smallest sum of numbers: {min}");
}

void Solution_56()
{
    int rows = SetNumber("rows");
    int columns = SetNumber("columns");
    if (rows != columns)
    {
        int min = SetNumber("min value");
        int max = SetNumber("max value");
        int[,] matrix = GetRandomMatrix(rows, columns, min, max);
        PrintMatrix(matrix);
        Console.WriteLine();
        Console.Write($"Sum of numbers in each rows: ");
        int[] array = SumRowsMatrix(matrix);
        PrintArray(array);
        CompareResult(array);
    }
    else Console.WriteLine("Error: enter a rectangular array");
}


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Чтобы произведение 2-х матриц AxB выполнилось, необходимо чтобы столбец матрицы A был РАВЕН строке матрицы B!


// Произведение двух матриц и создание результирующей матрицы
int[,] ProductTwoMatrix(int[,] matrixA, int[,] matrixB)
{
    var matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            matrixC[i, j] = 0;

            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}

void Solution_58()
{
    int rows = SetNumber("rows matrix A");
    int columns = SetNumber("columns matrix B");
    int general = SetNumber("columns matrix A and rows matrix B");
    int minA = SetNumber("min value A");
    int maxA = SetNumber("max value A");
    int minB = SetNumber("min value B");
    int maxB = SetNumber("max value B");
    int[,] matr_A = GetRandomMatrix(rows, general, minA, maxA);
    Console.WriteLine("Matrix A:");
    PrintMatrix(matr_A);
    Console.WriteLine();
    int[,] matr_B = GetRandomMatrix(general, columns, minB, maxB);
    Console.WriteLine("Matrix B:");
    PrintMatrix(matr_B);
    Console.WriteLine();
    Console.WriteLine("Resulting matrix C:");
    PrintMatrix(ProductTwoMatrix(matr_A, matr_B));

}


// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// Задаём трёхмерный массив неповторяющихся чисел
int[,,] Get3DArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    var rand = new Random();
    int num = rand.Next(10, 100);

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                if (num > 99) num = 10;
                array[i, j, k] = num;
                num++;
            }
        }
    }
    return array;
}

// Вывод трёхмерного массива на экран
void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k}); ");
            }
            Console.WriteLine();
        }
    }
}

void Solution_60()
{
    int x = SetNumber("argument X");
    int y = SetNumber("argument Y");
    int z = SetNumber("argument Z");
    Print3DArray(Get3DArray(x, y, z));
}


// Задача 62. Напишите программу, которая заполнит спирально массив. Размер вводит юзер.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// Заполнение матрицы спирально
int[,] SpiralMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int i = 0;
    int j = -1;         //т.к. начало цикла начинается с итерации j, заполнять будем с 0-индекса
    int count = 1;      //с каждым циклом заполнения количество заполняемых строк и столбцов уменьшаем на 1

    for (int num = 1; num <= rows * columns;)
    {
        while ((j < columns - count) && (num <= rows * columns))
        {
            j++;
            matrix[i, j] = num;
            num++;
        }
        while ((i < rows - count) && (num <= rows * columns))
        {
            i++;
            matrix[i, j] = num;
            num++;
        }
        while ((j >= count) && (num <= rows * columns))
        {
            j--;
            matrix[i, j] = num;
            num++;
        }
        count++;

        while ((i >= count) && (num <= rows * columns))
        {
            i--;
            matrix[i, j] = num;
            num++;
        }
    }

    return matrix;
}

// Вывод спиралевидной матрицы
void PrintSpiralMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10)
            {
                Console.Write($"{"0" + Convert.ToString(matrix[i, j])} ");
            }
            else Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Solution_62()
{
    int rows = SetNumber("rows");
    int columns = SetNumber("columns");
    Console.WriteLine();
    PrintSpiralMatrix(SpiralMatrix(rows, columns));
}



void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("1. Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
        Console.WriteLine("2. Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
        Console.WriteLine("3. Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
        Console.WriteLine("4. Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
        Console.WriteLine("5. Задача 62. Напишите программу, которая заполнит спирально массив . Размер вводит юзер.");
        Console.WriteLine("0. End");

        int numTask = SetNumber("task");

        switch (numTask)
        {
            case 0: return; break;
            case 1: Solution_54(); break;
            case 2: Solution_56(); break;
            case 3: Solution_58(); break;
            case 4: Solution_60(); break;
            case 5: Solution_62(); break;
            default: Console.WriteLine("Error"); break;
        }
    }
}

Start();