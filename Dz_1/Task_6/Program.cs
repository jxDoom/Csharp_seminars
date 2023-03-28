/* Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/


System.Console.WriteLine("Enter number: ");
string strNum = System.Console.ReadLine();
int num = Convert.ToInt32(strNum);

if (num % 2 == 0){
    System.Console.WriteLine($"{num} - even number");
}
else{
    System.Console.WriteLine($"{num} - odd number");
}