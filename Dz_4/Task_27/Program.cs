// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


int SetNumber(string text = "")
{
    Console.Write($"Enter number {text}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int SumAllDigits(int num)
{
    int result = 0;

    for (; num > 0;)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

int number = SetNumber();
System.Console.WriteLine($"The sum of all digits in a number {number} equals {SumAllDigits(number)}");
