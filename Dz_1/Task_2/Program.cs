/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/


Console.Clear();
/*
int num1 = new Random().Next(-9, 11);
System.Console.WriteLine($"First number: {num1}");

int num2 = new Random().Next(-9, 11);
System.Console.WriteLine($"Second number: {num2}");
*/
System.Console.WriteLine("Enter first number: ");
string strNum1 = System.Console.ReadLine();
int num1 = Convert.ToInt32(strNum1);

System.Console.WriteLine("Enter second number: ");
string strNum2 = System.Console.ReadLine();
int num2 = Convert.ToInt32(strNum2);

int max;

if (num1 > num2)
{
    max = num1;
    System.Console.WriteLine($"Max number = {num1} and min number = {num2}");
}
else if (num1 < num2)
{
    max = num2;
    System.Console.WriteLine($"Max number = {num2} and min number = {num1}");
}
else
{
    System.Console.WriteLine($"First number equals second number");
}