using System;

namespace Lab5
{
    /**
     * Класс чек.
     */
    class Check
    {
        // Хранит цену услуг, товаров итд.
        public double Price { get; set; }

        // Переопределенный tostring по заданию.
        public override string ToString()
        {
            return $"{GetType()}\n{Price}";
        }
    }
}
