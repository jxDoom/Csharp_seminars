// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] GetRandomBitArray(int quantity)
{
    int[] array = new int[quantity];
    Random rnd = new();

    for (int i = 0; i < quantity; i++)
        array[i] = rnd.Next(100);
    return array;
}

int[] numbers = GetRandomBitArray(8);
System.Console.WriteLine(string.Join("; ", numbers));


// Эталонное решение
/*
//Ввод числа с экрана
int Prompt(string message)
{
    System.Console.WriteLine(message);          //Выводим приглашение ко вводу
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput);          //Приводим к числу
    return result;                              //Возвращаем результат
}

//Метод для получения случайных чисел массива
int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];              //Объявляем массив
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);     //Заполняем случайными числами из диапазона SatrArr до EndArr
    }
    return array;
}

//Вывод массива на экран
void PrintArray(int[] array)
{
    System.Console.Write("[");

    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");              //Вывод значения массива
    }
    System.Console.Write($"{array[array.Length - 1]}");     //Вывод значения массива
    System.Console.WriteLine("]");
}

int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение для диапазона случайного числа: ");
int max = Prompt("Конечное значение для диапазона случайного числа: ");
int[] array = GenerateArray(length, min, max);              //Заполнение массива случайными числами

PrintArray(array);                                          //Вывод массива
*/