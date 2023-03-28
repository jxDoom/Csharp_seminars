/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/


Console.Clear();

int num1 = new Random().Next(-100, 101);
System.Console.WriteLine($"First number: {num1}");

int num2 = new Random().Next(-100, 101);
System.Console.WriteLine($"Second number: {num2}");

int num3 = new Random().Next(-100, 101);
System.Console.WriteLine($"Third number: {num3}");

/*
System.Console.WriteLine("Enter first number: ");
string strNum1 = System.Console.ReadLine();
int num1 = Convert.ToInt32(strNum1);

System.Console.WriteLine("Enter second number: ");
string strNum2 = System.Console.ReadLine();
int num2 = Convert.ToInt32(strNum2);

System.Console.WriteLine("Enter third number: ");
string strNum3 = System.Console.ReadLine();
int num3 = Convert.ToInt32(strNum3);
*/

int max = num1;

if (num2 > max){
    if (num2 > num3){
        max = num2;
        System.Console.WriteLine($"Max number = {max}");
    }
    else{
        max = num3;
        System.Console.WriteLine($"Max number = {max}");
    }
}
else if (num3 > max){
    max = num3;
    System.Console.WriteLine($"Max number = {max}");
}
else{
    System.Console.WriteLine($"Max number = {max}");
}
