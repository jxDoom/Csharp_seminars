﻿Console.Clear();

//Ввод строки с клавиатуры
string SetElement(string text)
{
    Console.Write($"Enter any number or word or symbol {text}: ");
    string el = Convert.ToString(Console.ReadLine()!);
    return el;
}

//Вывод массива на экран
void PrintArray(string[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
    Console.WriteLine();
}

//Создание массива из введеных строк
string[] ArrayOfString()
{
    Console.WriteLine("Enter quantity of elements in the array: ");
    int size = int.Parse(Console.ReadLine()!);
    string[] array = new string[size];

    for (int i = 0; i < size; i++)
    {
        string element = SetElement($"N{i + 1}");
        array[i] = element;
    }
    return array;
}

//Формирование нового массива из старого, где длина строк каждого элемента массива
//меньше или равна 3 символам
string[] NewArrayOfString(string[] array)
{
    int count = 0;
    string[] arr = new string[count];

    for (int i = 0; i < array.Length; i++)
    {
        //for (int j = 0; j < ; j++)
        //{
            if (array[i].Length <= 3)
            {
                arr[count] = array[i];
                count++;
            }
        //}
    }
    PrintArray(arr);
    return arr;
}

void Start()
{
    string[] array = ArrayOfString();
    PrintArray(array);
    //PrintArray(NewArrayOfString(array));
    NewArrayOfString(array);
}

Start();