// Ханойские башни на 3 шпиля (стойки)

void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
// with - первый "рабочий" шпиль, откуда будет браться текущий блин,
// on - тот шпиль, которая для нас будет являться тем шпилем, на котором пирамидка должна оказаться
// some - средний шпиль, count - количество блинов, которые у нас есть
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.Write($"{count}: ");
    Console.WriteLine($"{with} >> {on}");
    Console.WriteLine();
    if (count > 1) Towers(some, on, with, count - 1);
}

Towers();