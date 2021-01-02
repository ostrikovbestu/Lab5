using System;

namespace Lab5
{
    /**
     * Абстрактный класс документ.
     * Имеет соответствующий модификатор.
     * Определим общие члены, для всех возможных классов унаследованных от документа.
     */
    abstract class Document
    {
        public string DocumentType { get; set; } = "AbstractDocument";
        
        public Date Date { get; set; } = null;

        public Organization Organization { get; set; } = null;

        public Document(Date date, Organization organization)
        {
            Date = date;
            Organization = organization;
        }

        /**
         * Определим общее поведение, для наследников класса документ,
         * которое отображает информацию о документе.
         * Также, сделаем класс виртуальным, чтобы в наследниках была возможность
         * переопределить этот метод, если это понадобится.
         */
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Тип документа: {DocumentType}" +
                $"\nДата создания документа: {Date}" +
                $"\n**Организация за которой закреплен документ**\n{Organization.GetFullInfo()}");
        }
    }
}
