// Task_10
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

/*
int num = new Random().Next(100, 1000);
System.Console.WriteLine($"{num}");

int result1 = num % 100;
int result2 = result1 / 10;                             //result2 = num / 10 % 10;
System.Console.WriteLine($"{result2}");
*/


// Task_13
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

/*
System.Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int result = 0;

if (num > 99 || num < -99)
{
    while (num >= 1000 || num <= -1000)
    {
        num /= 10;
    }
    result = num % 10;
    System.Console.WriteLine($"{Math.Abs(result)}");
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}
*/

// Есть второй вариант решения задачи, но нужно учесть, что не работает с отрицательными значениями:
/*
Console.Write("Введите число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2)                                               //.length -> 1, 2, 3, ...
{
    Console.WriteLine("третья цифра -> " + anyNumberText[2]);               //[i] - index, начинается с 0
}
else
{
    Console.WriteLine("-> третьей цифры нет");
}
*/


// Task_15
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

/*
System.Console.Write("Введите цифру: ");
int num = int.Parse(Console.ReadLine());

switch (num)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5: System.Console.WriteLine("Not a day off"); break;
    case 6:
    case 7: System.Console.WriteLine("Day off"); break;
    default: System.Console.WriteLine("Day of the week does not exist"); break;
}
*/
