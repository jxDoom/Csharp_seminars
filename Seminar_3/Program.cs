// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
Console.Write("Enter number X: ");
int numX = int.Parse(Console.ReadLine());

Console.Write("Enter number Y: ");
int numY = int.Parse(Console.ReadLine());

if (numX > 0 && numY > 0)
{
    System.Console.WriteLine("Section 1");
}
else if (numX < 0 && numY > 0)
{
    System.Console.WriteLine("Section 2");
}
else if (numX < 0 && numY < 0)
{
    System.Console.WriteLine("Section 3");
}
else if (numX > 0 && numY < 0)
{
    System.Console.WriteLine("Section 4");
}
*/
// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).
/*
Console.WriteLine("Enter number of quter");
int num = int.Parse(Console.ReadLine());

switch (num)
{
    case 1: Console.WriteLine("X>0, Y>0"); break;
    case 2: Console.WriteLine("X<0, Y>0"); break;
    case 3: Console.WriteLine("X<0, Y<0"); break;
    case 4: Console.WriteLine("X>0, Y<0"); break;
    default: Console.WriteLine("Wrong quoter num"); break;

}
*/

// На вход будет подаваться число (сумма вклада).
// При значении меньше 100, будет начислено 5 %, если значение находится в диапазоне от ста до двухсот — 7 %,
// если больше — 10 %. Отработав, программа должна вывести общую сумму с начисленными процентами.
// Для решения этой задачи воспользуемся выражением Convert.ToDouble(Console.ReadLine()),
// которое нам пригодится для получения вводимого с клавиатуры числа.

// Пусть банк регулярно начисляет по всем вкладам не только положенные по договору проценты,
// но еще и бонусы. И пусть, к примеру, банк решит выполнить доначисление
// по всем клиентским вкладам в размере 15 единиц без учета суммы.
// Поменяем программу, отображенную выше, чтобы к итоговой сумме были добавлены еще и бонусы.
/*
System.Console.Write("Сумма вклада: ");
double sum = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Бонус: ");
double bonus = Convert.ToDouble(Console.ReadLine());

if (sum < 100)
{
    sum = sum + 0.05 * sum;
    sum += bonus;
}
else if (sum >= 100 && sum < 200)
{
    sum = sum + 0.07 * sum;
    sum += bonus;
}
else if (sum >= 200)
{
    sum = sum + 0.1 * sum;
    sum += bonus;
}
System.Console.WriteLine($"Сумма с начисленными процентами и бонусами: {sum}");
*/

// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
/*
Console.Write("Координата точки A по X: ");
int Xa = int.Parse(Console.ReadLine());
Console.Write("Координата точки A по Y: ");
int Ya = int.Parse(Console.ReadLine());

Console.Write("Координата точки B по X: ");
int Xb = int.Parse(Console.ReadLine());
Console.Write("Координата точки B по Y: ");
int Yb = int.Parse(Console.ReadLine());

double scalar = Math.Sqrt(Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2));
System.Console.WriteLine($"Расстояние между точкими в 2D пространстве: {scalar}");
*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4

Console.Write("Enter number N: ");
int N = int.Parse(Console.ReadLine());
/*
for (int i = 1; i <= N; i++)
{
    System.Console.Write($"{Math.Pow(i, 2)} ");
}
*/
int i = 1;
while (i <= N)
{
    System.Console.Write($"{Math.Pow(i, 2)} ");
    i++;
}

// for - цикл для работы с итераторами, а while - цикл для работы с условием. Оба цикла очень важны и полезны.
// while может зависать и не выйти из программы, for всегда заканчивается.