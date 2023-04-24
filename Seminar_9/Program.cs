// Задача ***. Задать 10 вопросов на каждом из которых будут 4 варианта ответа, один из них будет правильный
/*
string[,] QuestionsArray()
{
    string[,] matrix = {{"2+2 = ?", "13", "2", "4", "5", "4"},
    {"А и Б сидели на трубе, что с ними стало", "Упали", "Пропали", "Сбежали", "Потерялись", "Сбежали"}
    // {"", "", "", "", "", ""},
    // {"", "", "", "", "", ""},
    // {"", "", "", "", "", ""},
    // {"", "", "", "", "", ""},
    // {"", "", "", "", "", ""},
    // {"", "", "", "", "", ""},
    };
    return matrix;
}

string[,] questions = QuestionsArray();
int count = 0;
for (int i = 0; i < questions.GetLength(0); i++)
{
    Console.WriteLine(questions[i, 0]);

    for (int j = 1; j < questions.GetLength(1) - 1; j++)
    {
        Console.WriteLine(questions[i, j]);
    }
    Console.WriteLine();


    string answer = Console.ReadLine();
    if (answer == questions[i, questions.GetLength(1) - 1])
    {
        count++;
    }

    Console.WriteLine($"Correct answers: {count}");
}
*/

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

//Ввод числа с клавиатуры
int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SumAllDigits(int num)
{
    // if (num == 0) return 0;
    // return (num % 10 + SumAllDigits(num / 10));
    return (num == 0) ? 0 : (num % 10 + SumAllDigits(num / 10));
}
int number = SetNumber("");
Console.WriteLine($"Sum numbers {number} equals {SumAllDigits(number)}");