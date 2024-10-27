using Tyuiu.KhrapkoDD.Sprint3.Task6.V18.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        int startValue = 9;
        int stopValue = 18;

        Console.Title = "Спринт #3 | Выполнил: Храпко Д. Д. | ИСТНб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнил: Храпко Данил Дмитриевич | ИСТНб-24-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих       *");
        Console.WriteLine("* числовому отрезку [9, 18] количество всех делителей меньше 10           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Начало отрезка: " + startValue);
        Console.WriteLine("Конец отрезка: " + stopValue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.GetSumTheDivisors(startValue, stopValue));
    }
}