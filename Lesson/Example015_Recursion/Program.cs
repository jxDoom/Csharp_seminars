// 1.1. Собрать строку с числами от a до b, a <= b

string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return string.Empty;
}

//Console.WriteLine(NumbersRec(2, 10));


// 1.2. Собрать строку с числами от a до b, a >= b

string NumbersRecDec(int a, int b)
{
    if (a <= b) return NumbersRecDec(a + 1, b) + $"{a} ";
    else return string.Empty;
}

//Console.WriteLine(NumbersRecDec(2, 10));


// 2. Сумма чисел от 1 до n

int SumRec(int n)
{
    return n == 0 ? 0 : n + SumRec(n - 1);
}

//Console.WriteLine(SumRec(10));


// 3. Факториал числа

int FactorialRec(int n)
{
    return n == 1 ? 1 : n * FactorialRec(n - 1);
}

//Console.WriteLine(FactorialRec(10));


// 4.1. Вычислить a в степени n

int PowerRec(int a, int n)
{
    return n == 0 ? 1 : PowerRec(a, n - 1) * a;
}
// 4.2. Решение лучше (математически):

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}

//Console.WriteLine(PowerRec(2, 10));
//Console.WriteLine(PowerRecMath(2, 10));

// 5. Перебор слов

int n = 1;
void FindWords(string alphabet, char[] word, int lenght = 0)
{
    if (lenght == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[lenght] = alphabet[i];
        FindWords(alphabet, word, lenght + 1);
    }
}

//FindWords("аисв", new char[5]);


// 6.1. Как посмотреть содержимое папки?

//string path = "C:/Семинары по C#/Lesson/Example007_Magic";
DirectoryInfo di = new DirectoryInfo(path);
Console.WriteLine(di.CreationTime); //дата создания директории
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
     Console.WriteLine(fi[i].Name); //ее содержимое
}

// 6.2. Теперь с помощью рекурсии:

void CatalogInfo(string path, string indent = "")   //1-й аргумент (path) это путь к текущей папке, 2-й это отступы
{
    DirectoryInfo catalog = new DirectoryInfo(path);    //информация о той директории, в которую мы вошли по пути path

    DirectoryInfo[] catalogs = catalog.GetDirectories();    //массив всех файлов, нахоящихся в этой папке
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

    FileInfo[] files = catalog.GetFiles();  //список файлов в текущей директории

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}
string path = @"C:/Семинары по C#";
CatalogInfo(path);