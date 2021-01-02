using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    /**
     * Класс квитанция.
     * Поскольку квитанция является документом, сделаем наследование от Document.
     */
    class Receipt : Document
    {
        // Словарь, для хранения наименования товара и его стоимости.
        public Dictionary<string, double> ServicePricePair { get; set; } = new Dictionary<string, double>();
        // Храним объект чека. Модификация на уровне объекта.
        public Check Check { get; private set; } = new Check();


        public Receipt(Date date, Organization organization) : base(date, organization)
        {
            DocumentType = "Квитанция";
        }


        // Метод для расчета финальной стоимости и занесения ее в чек.
        public void CalculateFinalPrice()
        {
            Check.Price = ServicePricePair.Values.Sum();
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"**Информация о документе**\n" +
                $"=={DocumentType}\n" +
                $"Время создания квитанции: {Date}\n" +
                $"**Организация за которой закреплена квитанция**\n{Organization.GetFullInfo()}");
        }

        public override string ToString()
        {
            return $"{GetType()}\n{DocumentType}\n{Date}\n{ServicePricePair}\n{Organization}\n{Check}";
        }
    }
}
