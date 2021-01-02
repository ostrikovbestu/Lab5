namespace Lab5
{
    /**
     * Абстрактный класс, определяет некое поведение для классов, в текущем контексте
     * для класса организация.
     * У любой организации обязательно есть базовые данные,
     * например название, какой-нибудь номер в реестре,
     * контактный телефон, адрес...
     * 
     * Определим свойства отвечающие за эти данные.
     * Также добавим метод, который должен отображать все эти данные сразу.
     * Ключевое слово abstract у членов класса, означает, что они не имеют реализации.
     */
    abstract class Organization
    {
        public abstract string Name { get; set; }

        public abstract int Id { get; set; }

        public abstract string PhoneNumber { get; set; }

        public abstract string Address { get; set; }

        public abstract string GetFullInfo();
    }
}
