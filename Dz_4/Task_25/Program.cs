// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int SetNumber(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

bool ValidateExponent(int exponent)
{
    if (exponent < 0)
    {
        System.Console.WriteLine("Exponent cannot be less than zero");
        return false;
    }
    else return true;
}

int A = SetNumber("Enter number A: ");
int B = SetNumber("Enter number B: ");

double result = Math.Pow(A, B);
if (ValidateExponent(B))
{
    System.Console.WriteLine($"Number {A} in exponent {B} equals {result}");
}