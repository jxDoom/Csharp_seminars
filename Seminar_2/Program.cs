// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую

// Например:
// 78->8
// 12->2
// 85->8

/*
int num = new Random().Next(10, 100);            // [10, 100)

int num1 = num / 10;
int num2 = num % 10;

Console.WriteLine(num);

if (num1 > num2)
{
    System.Console.WriteLine($"num1 > num2 max = {num1} ");
}
else if (num1 < num2)
{
    System.Console.WriteLine($"num1 < num2 max = {num2} ");
}
else
{
    System.Console.WriteLine($"num1 == num2 max = {num1} ");
}
*/

// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

/*
int num = new Random().Next(100, 1000);

System.Console.WriteLine($"{num}");                             // cw+Tab

int num1 = num / 100;
int num2 = num % 10;

int num3 = num1*10+num2;
System.Console.WriteLine(num3);
*/

// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

/*
int num1 = int.Parse(System.Console.ReadLine());
int num2 = int.Parse(System.Console.ReadLine());

int result = num1 % num2;

if (result == 0)
{
    System.Console.WriteLine($"{num1} кратно {num2}");
}
else
{
    System.Console.WriteLine(result);
}
*/

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

// int num = new Random().Next(161, 165);
// System.Console.WriteLine(num);
/*int num = int.Parse(System.Console.ReadLine());

int result1 = num % 7;
int result2 = num % 23;

if (result1 == 0 && result2 == 0)
{
    System.Console.WriteLine("multiple");
}
else
{
    System.Console.WriteLine("not a multiple");
}
*/


// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8, 9  ->  нет

/*
int num1 = int.Parse(System.Console.ReadLine());
int num2 = int.Parse(System.Console.ReadLine());

if (num1 * num1 == num2)
{
    System.Console.WriteLine("Is a square");
}
else if (num1 == num2 * num2)
{
    System.Console.WriteLine("Is a square");
}
else
{
    System.Console.WriteLine("Is not a square");
}
*/