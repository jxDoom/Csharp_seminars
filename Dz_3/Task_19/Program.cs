// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


System.Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
string numText = Convert.ToString(num);

if (num >= 10000 && num < 100000)
{
    if (numText[0] == numText[4] && numText[1] == numText[3])
    {
        System.Console.WriteLine("Yes, palindrome");
    }
    else
    {
        System.Console.WriteLine("Not a palindrome");
    }
}
else
{
    System.Console.WriteLine("Entered non-five-digit or negative five-digit number");
}
