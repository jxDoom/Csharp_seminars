// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


//Ввод числа с клавиатуры
int SetNumber(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    int number = int.Parse(ReadInput);
    return number;
}

//Создание массива из введеных чисел
int[] InputArray(int count)
{
    int[] array = new int[count];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = SetNumber($"Enter number {i + 1}: ");
    }
    return array;
}

//Вывод массива на экран
void PrintArray(int[] array)
{
    Console.Write("[" + string.Join(", ", array) + "]");
}

//Счетчик чисел >0 в массиве
int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    Console.WriteLine($"Count of positive numbers in the array = {count}");
    return count;
}

void Solution_41()
{
    int size = SetNumber("Enter the length of the array: ");
    int[] array;
    array = InputArray(size);
    PrintArray(array);
    Console.WriteLine();
    CountPositiveNumbers(array);
}



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


const int coefficient = 0;
const int constant = 1;
const int x_coord = 0;
const int y_coord = 1;
const int line1 = 1;
const int line2 = 2;

//Ввод числа
double SetDoubleNumber(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

//Ввод параметров прямой
double[] InputLineData(int line)
{
    double[] linedata = new double[2];
    linedata[coefficient] = SetDoubleNumber($"Enter coefficient for line {line}: ");
    linedata[constant] = SetDoubleNumber($"Enter constant for line {line}: ");
    return linedata;
}

//Поиск координат
double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[x_coord] = (lineData1[constant] - lineData2[constant]) /
(lineData2[coefficient] - lineData1[coefficient]);
    coord[y_coord] = lineData1[coefficient] * coord[x_coord] + lineData1[constant];
    return coord;
}

//Сравнение прямых, совпадают параметры или нет
bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[coefficient] == lineData2[coefficient])
    {
        if (lineData1[constant] == lineData2[constant])
        {
            Console.WriteLine("Lines coincide");
            return false;
        }
        else
        {
            Console.WriteLine("Lines are parallel");
            return false;
        }
    }
    else return true;
}

void Solution_43()
{
    double[] lineData1 = InputLineData(line1);
    double[] lineData2 = InputLineData(line2);

    if (ValidateLines(lineData1, lineData2))
    {
        double[] coord = FindCoords(lineData1, lineData2);
        Console.Write("Equations intersection point ");
        Console.Write($"y = {lineData1[coefficient]}*x + {lineData1[constant]} and ");
        Console.Write($"y = {lineData2[coefficient]}*x + {lineData2[constant]} ");
        Console.WriteLine($"has coordinates {coord[x_coord]}, {coord[y_coord]}");
    }
}

Solution_41();
Solution_43();
