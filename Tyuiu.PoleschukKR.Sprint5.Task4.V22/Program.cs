using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PoleschukKR.Sprint5.Task4.V22.Lib;

namespace Tyuiu.PoleschukKR.Sprint5.Task4.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Полещук К. Р. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение файла                                                      *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Полещук Кирилл Романович | ИИПб-23-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:DataSprint5InPutDataFileTask4V0.txt (файл взять из архива    *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:DataSprint5 и копир. *");
            Console.WriteLine("* в неё файл) в котором есть вещественное значение. Прочитать значение    *");
            Console.WriteLine("*  из файла и подставить вместо Х в формуле y = (x^-2 + 2)sin(x)          *");
            Console.WriteLine("* Вычислить значение по формуле (Полученное значение округлить            *");
            Console.WriteLine("* до трёх знаков после запятой) и вернуть полученный результат на консоль.*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V22.txt";

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine(res);


            Console.ReadLine();
        }
    }
}
