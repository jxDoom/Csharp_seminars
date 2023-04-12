// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// Заполнение массива случайными числами и вывод его на экран
int[] GenerateInputArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    Console.WriteLine("[" + string.Join(", ", array) + "]");
    return array;
}

// Счетчик чётных чисел в массиве
void EvenNumberCounter(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    Console.WriteLine($"Number of even numbers in array: {count}");
}

void Solution_34()
{
    int size = 15;
    int min = 100;
    int max = 999;
    EvenNumberCounter(GenerateInputArray(size, min, max));
}



// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


//Сумма элементов массива, стоящих на нечетных позициях
void SumOfArrayNumber(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum = sum + arr[i];
    }
    Console.WriteLine($"Sum of array elements at odd positions = {sum}");
}

void Solution_36()
{
    int size = 10;
    int min = -30;
    int max = 50;
    SumOfArrayNumber(GenerateInputArray(size, min, max));
}



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.
// [3 7 22 2 78] -> 76


// Заполнение массива случайными вещественными числами и вывод его на экран
double[] DoubleArray(int size)
{
    double[] array = new double[size];
    int a = new Random().Next(20, 50);          //случайное число a
    int b = new Random().Next(100);             //случайное число b
    Console.WriteLine($"Random number a: {a} and Random number b: {b}");
    if (a != b)
    {
        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().NextDouble() * (b - a);
        }
        Console.WriteLine("[" + string.Join("; ", array) + "]");
    }
    else
    {
        Console.WriteLine("Output: null array");
    }
    return array;
}

void DifferenceMinMax(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
        else if (arr[i] > max) max = arr[i];
    }
    System.Console.WriteLine($"Array minimum value: {min} and Array maximum value {max}");
    double dif = max - min;
    Console.WriteLine($"Difference between Maximum and Minimum: {Math.Abs(dif)}");
}

void Solution_38()
{
    int size = 7;
    DifferenceMinMax(DoubleArray(size));
}



Solution_34();
Console.WriteLine();
Solution_36();
Console.WriteLine();
Solution_38();
