/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/


System.Console.WriteLine("Enter number: ");
string strN = System.Console.ReadLine();
int N = Convert.ToInt32(strN);
int i = 2;                                              // i = index

if (N > 1){
    System.Console.WriteLine("Even numbers: ");
    while (i <= N)
    {
        System.Console.Write($"{i}\t");
        i += 2;
    }
}
else{
    System.Console.WriteLine("No even numbers");
}
