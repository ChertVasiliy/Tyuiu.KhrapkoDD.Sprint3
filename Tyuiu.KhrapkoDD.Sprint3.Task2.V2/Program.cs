using Tyuiu.KhrapkoDD.Sprint3.Task2.V2.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        int startValue = 1;
        int stopValue = 7;

        Console.Title = "Спринт #3 | Выполнил: Храпко Д. Д. | ИСТНб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнил: Храпко Данил Дмитриевич | ИСТНб-24-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл for, которая вычисляет                *");
        Console.WriteLine("* сумму ряда по формуле                                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Исходное значение k:" + startValue);
        Console.WriteLine("Конечное значение k:" + stopValue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.GetMultiplySeries(startValue, stopValue));
    }
}