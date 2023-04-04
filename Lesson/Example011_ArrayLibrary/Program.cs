void FillArray(int[] collection)                // Метод, который ничего не возвращает,
                                                // то есть в этой части кода мы не будем использовать оператор return
{
    int lengt = collection.Length;
    int index = 0;
    while (index < lengt)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.Write($"{col[position]} ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;                          //индекс массива от 0 до N
    int position = -1;                      //позиция числа которую нужно найти в массиве, если этого числа нет в массиве, то возвращается -1
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10];

FillArray(array);               // заполняем массив
PrintArray(array);              // выводим его
System.Console.WriteLine();

int pos = IndexOf(array, 4);
System.Console.WriteLine(pos);