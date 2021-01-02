using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    /**
     * Класс организация, потомок абстрактного класса.
     */
    class FreshMarket : Organization
    {
        /**
         * Дадим реализацию свойствам и методу, которые описаны в абстрактном классе.
         * Для каждого из классов, будет разная реализация.
         */
        public override string Name { get; set; } = "Продуктовый магазин \"Fresh\"";

        public override int Id { get; set; } = 4545;

        public override string PhoneNumber { get; set; } = "8(017)349-01-31";

        public override string Address { get; set; } = "г.Копыль, Улица Некрасова 43";

        public override string GetFullInfo()
        {
            return $"Наименование: {Name}\n" +
                $"Номер в реестре: {Id}\n" +
                $"Телефон: {PhoneNumber}\n" +
                $"Адрес: {Address}";
        }
    }
}
