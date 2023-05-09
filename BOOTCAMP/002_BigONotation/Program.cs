﻿// Допустим нам надо создать таблицу умножения в двумерном массиве, размер матрицы задает пользователь

Console.Clear();

Console.Write("Ведите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= n; i++)
// {
//     for (int j = 1; j <= n; j++)
//     {
//         Console.Write(i * j + "\t");
//     }
//     Console.WriteLine();
// }
// Сложность данного алгоритма равна O(n^2), алгоритм является квадратным.

// Данную задачу можно немного упростить, следовательно уменьшить время работы программы, время подсчета.
// Заметим, что нам нужно знать то что выше главной диагонали или наоборот, все что ниже,
// а остальное смежно заполнить.

int[,] matrix = new int[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        matrix[i, j] = (i + 1) * (j + 1);
        matrix[j, i] = (i + 1) * (j + 1);
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
// Сложность O(n^2 / 2)
