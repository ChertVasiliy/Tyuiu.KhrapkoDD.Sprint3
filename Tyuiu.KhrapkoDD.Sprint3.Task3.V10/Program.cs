using Tyuiu.KhrapkoDD.Sprint3.Task3.V10.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        string value = "gdfppf vfppt p";
        char item = 'p';

        Console.Title = "Спринт #3 | Выполнил: Храпко Д. Д. | ИСТНб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнил: Храпко Данил Дмитриевич | ИСТНб-24-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Используя цикл foreach подсчитать количество букв “p” в строке          *");
        Console.WriteLine("* gdfppf vfppt p                                                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Исходная строка = " + value);
        Console.WriteLine("Удаляемый символ = " + item);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Преобразованная строка = " + ds.DeleteCharInString(value, item));
        Console.ReadKey();
    }
}