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
    int tmp = num;                                      //введем доп. переменную в цикле и делаем с ним что хотим,
                                                        //переменная num возможно применится дальше

    while (tmp >= 1000 || tmp <= -1000)
    {
        tmp /= 10;
    }
    result = tmp % 10;
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
//Так как у нас идет строгое сравнение и нам нужно сделать кейсы стринговыми, то эту задачу лучше решить так:
/*
Console.WriteLine("Enter dayWeek : ");
string strDayWeek = Console.ReadLine();

PrintIsWeekend(strDayWeek);

void PrintIsWeekend(string dayWeek)
{

    switch (dayWeek)
    {
        case "1":
            Console.WriteLine("Понедельник- НЕТ"); break;
        case "2":
            Console.WriteLine("Вторник- НЕТ"); break;
        case "3":
            Console.WriteLine("Среда- НЕТ"); break;
        case "4":
            Console.WriteLine("Четверг- НЕТ"); break;
        case "5":
            Console.WriteLine("Пятница- Да"); break;
        case "6":
            Console.WriteLine("Суббота- Нет"); break;
        case "7":
            Console.WriteLine("Воскресенье- Нет"); break;
    }
}
*/
int SetNumber(string text = "")
{
    Console.Write($"Enter number {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool ValidateWeekday(int dayWeek)
{
    return dayWeek >= 1 && dayWeek <= 7 ? true : false;         //тернарный оператор (ещё 131 строчка)
}

string PrintWeekendDay(int dayWeek)
{
    return dayWeek > 5 && dayWeek <= 7 ? "Weekend)))" : "Work day(((";
}

int weekDay = SetNumber("week day");

if (ValidateWeekday(weekDay))
{
    System.Console.WriteLine(PrintWeekendDay(weekDay));
}
else
{
    System.Console.WriteLine("Week day not valid()");
}