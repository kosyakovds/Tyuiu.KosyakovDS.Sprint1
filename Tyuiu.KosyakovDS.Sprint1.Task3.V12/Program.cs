using Tyuiu.KosyakovDS.Sprint1.Task3.V12.Lib;

namespace Tyuiu.KosyakovDS.Sprint1.Task3.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил Косяков Д. С. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Косяков Дмитрий Сергеевич | ИИПб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу для вычисления площади прямоугольного треугольника   *");
            Console.WriteLine("* по длинам двух катетов.                                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* x = 5, y = 4                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите длину первого катета:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину второго катета:");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Площадь треугольника: " + ds.TriangleArea(x, y));

            Console.ReadLine();
        }
    }
}
