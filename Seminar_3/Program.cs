// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Enter number of quter");
    int num=int.Parse(Console.ReadLine());
    
    switch(num)
    {
        case 1:Console.WriteLine("X>0, Y>0");break;
        case 2:Console.WriteLine("X<0, Y>0");break;
        case 3:Console.WriteLine("X<0, Y<0");break;
        case 4:Console.WriteLine("X>0, Y<0");break;
        default:Console.WriteLine("Wrong quoter num");break;
        
    }