Console.Clear();

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
string[] StrArray()
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
//меньше или равна 3-м символам
string[] NewStrArray(string[] array)
{
    int count = 0;
    string[] arr = new string[SizeNewStrArray(array)];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            arr[i] = array[i]!;
            count++;
        }
    }
    return arr;
}

int SizeNewStrArray(string[] array)
{
    int new_size = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4) new_size++;
    }
    return new_size;
}

void Start()
{
    string[] array = StrArray();
    Console.WriteLine("Initial Array:");
    PrintArray(array);
    string[] new_arr = NewStrArray(array);
    Console.WriteLine("New Resulting Array:");
    PrintArray(new_arr);
}

Start();