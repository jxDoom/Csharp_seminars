// Задача 24. Напишите программу, которая принимает на вход число (A) и выдает сумму чисел от 1 до A

// 7 -> 28
// 4 -> 10
// 8 -> 36

/*
int SetNumber(string text = "")
{
    Console.Write($"Enter number {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int num = SetNumber();
int sum = 0;
for (int i = 1; i <= num; i++)                                  //for(; ; ) - бесконечный цикл
{
    sum += i;
}

System.Console.WriteLine("sum = " + sum);


int a = 40;

int b = ++a;        //b = 41 a = 41               //префиксный инкремент или int b = ++a -> int b = a = a + 1
// b = a++; - постфиксный инкремент. b = 40, a = 41
b = a++;            //b = 40 a = 41
b = a++;            //b = 41 a = 42
a = 40;
a = --b;            //a = 39 b = 39
b = a--;            //a = 38 b = 39
*/


// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

/*
System.Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());
int count = 0;
int tmp = num;

// for (; tmp > 0; count++)
// {
//    tmp = tmp / 10;
// }

for (; tmp != 0; tmp /= 10)
{
    ++count;
}

System.Console.WriteLine($"{count} цифр в числе {num}");
*/

// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.


int[] numbers = GetArray();
System.Console.WriteLine(string.Join("; ", numbers));
int[] GetArray()
{
    int[] new_array = new int[8];
    Random rnd = new Random();
    for (int i = 0; i < 8; i++)
        new_array[i] = rnd.Next(0, 2);
    return new_array;
}

