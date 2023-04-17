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
                matrix[i, j] = rnd.Next(minValue, maxValue) + rnd.NextDouble();
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

    double[,] matrix = DoubleMatrix(m, n, minValue, maxValue);
    PrintDoubleMatrix(matrix);
}

Solution_47();


// Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве,
// и возвращает его индексы первого найденого числа или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет