using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    /**
     * Класс накладная.
     * Поскольку накладная является документом, то сделаем наследование от Document.
     */
    class ConsignmentNote : Document
    {
        // Словарь, для хранения наименования товара и его стоимости.
        public Dictionary<string, double> GoodsPricePair { get; set; }

        // Храним объект чека. Модификация на уровне объекта.
        public Check Check { get; private set; } = new Check();

        public ConsignmentNote(Date date, Organization organization) : base(date, organization)
        {
            DocumentType = "Накладная";
            GoodsPricePair = new Dictionary<string, double>();
        }

        // Переопределенный метод из абстрактного класса.
        public override void DisplayInfo()
        {
            Console.WriteLine($"**Информация о документе**\n" +
                $"=={DocumentType}\n" +
                $"Время создания накладной: {Date}\n" +
                $"**Организация за которой закреплена накладная**\n{Organization.GetFullInfo()}");
        }

        // Метод для расчета финальной стоимости и занесения ее в чек.
        public void CalculateFinalPrice()
        {
            Check.Price = GoodsPricePair.Values.Sum();
        }

        // Переопределенный tostring по заданию.
        public override string ToString()
        {
            return $"{GetType()}\n{DocumentType}\n{Date}\n{Organization}\n{GoodsPricePair}\n{Check}";
        }
    }
}
