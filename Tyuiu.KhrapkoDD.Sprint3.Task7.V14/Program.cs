using Tyuiu.KhrapkoDD.Sprint3.Task7.V14.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        int startValue = -5;
        int stopValue = 5;

        int len = ds.GetMassFunction(startValue, stopValue).Length;

        double[] res; res = new double[len]; res = ds.GetMassFunction(startValue, stopValue);

        Console.Title = "Спринт #3 | Выполнил: Храпко Д. Д. | ИСТНб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла for                                                *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #11                                                             *");
        Console.WriteLine("* Выполнил: Храпко Данил Дмитриевич | ИСТНб-24-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл for, которая вычисляет                *");
        Console.WriteLine("* сумму ряда по формуле                                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Начало отрезка: " + startValue);
        Console.WriteLine("Конец отрезка: " + stopValue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("+----------+---------+");
        Console.WriteLine("|    X     |  f(x)   |");
        Console.WriteLine("+----------+---------+");
        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine("|{0,5:d}     |  {1,5:f2} |", startValue, res[i]);
            startValue++;
        }
        Console.WriteLine("+---------+---------+");
        Console.ReadLine();
    }
}