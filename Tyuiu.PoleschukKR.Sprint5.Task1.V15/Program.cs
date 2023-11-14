using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PoleschukKR.Sprint5.Task1.V15.Lib;

namespace Tyuiu.PoleschukKR.Sprint5.Task1.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Полещук К. Р. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Полещук Кирилл Романович | ИИПб-23-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция, произвести табулирование на заданном диапазоне [-5:5]     *");
            Console.WriteLine("* c шагом один. Произвести проверку деления на 0.Вернуть 0 при делении    *");
            Console.WriteLine("* в текстовый файл OutPutFileTask1.txt и вывести на консоль.Округлить до 2*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Начальное значение: " + startValue);
            Console.WriteLine("Конечное значение: " + stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Cоздан!");
            Console.ReadKey();
        }
    }
}
