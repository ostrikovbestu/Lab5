using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    // Класс принтер.
    class Printer
    {
        // Полиморфный метод. Формальным параметром принимает ссылку на абстрактный класс.
        public void IAmPrinting(Document document)
        {
            // Определяем тип объекта с помощью is
            // и вызываем метод tostring, он вызывается автоматически(неявно) при печати на консоль
            if (document is ConsignmentNote)
            {
                Console.WriteLine($"Вызов метода ToString для класса НАКЛАДНАЯ\n" +
                    $"{document}");
            }
            else if (document is Receipt)
            {
                Console.WriteLine($"Вызов метода ToString для класса КВИТАНЦИЯ\n" +
                    $"{document}");
            }
        }
    }
}
