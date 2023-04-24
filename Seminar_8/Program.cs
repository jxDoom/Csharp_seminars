// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

//Задаём метод двумерного массива
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

//Вывод матрицы
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

//Метод замены первой строки с последней
void StringMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int n = matrix.GetLength(0);
            int tmp = matrix[0, j];
            matrix[0, j] = matrix[n - 1, j];
            matrix[n - 1, j] = tmp;
        }
    }
}

void Solution_53()
{
    int[,] matrix = GetRandomMatrix(5, 5, 0, 9);
    PrintMatrix(matrix);
    Console.WriteLine();
    StringMatrix(matrix);
    PrintMatrix(matrix);
}

//Solution_53();



// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.

//Метод замены строк на столбцы
int[,] RowsColumnsMatrix(int[,] matrix)
{
    int[,] matr = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            matr[i, j] = matrix[j, i];
        }
    }
    return matr;
}

bool SimmetrMatrix(int[,] matrix)
{
    if (matrix.GetLength(0) == matrix.GetLength(1))
    {
        return true;
    }
    else
    {
        Console.WriteLine("Matrix is not symmetrical");
        return false;
        //break;
    }
}

void Solution_55()
{
    int[,] matrix = GetRandomMatrix(4, 5, 0, 9);
    PrintMatrix(matrix);
    SimmetrMatrix(matrix);
    //for (; ; ) if (false) break;
    Console.WriteLine();
    int[,] newMatrix = RowsColumnsMatrix(matrix);
    PrintMatrix(newMatrix);
}

//Solution_55();


// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

