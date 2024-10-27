using Tyuiu.KhrapkoDD.Sprint3.Task4.V8.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        int startValue = -5;
        int stopValue = 5;

        Console.Title = "Спринт #3 | Выполнил: Храпко Д. Д. | ИСТНб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #8                                                              *");
        Console.WriteLine("* Выполнил: Храпко Данил Дмитриевич | ИСТНб-24-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить              *");
        Console.WriteLine("* значение функции y=x/(cos(x) + x)+0.5 При х = 0 прервать цикл.          *");
        Console.WriteLine("* Полученные значения перемножать.                                        *"); ;
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Начальное значение: " + startValue);
        Console.WriteLine("Конечное значение: " + stopValue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(startValue, stopValue));
    }
}