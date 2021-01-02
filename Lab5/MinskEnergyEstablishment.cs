namespace Lab5
{
    /**
     * Определим конкретную организацию, является потомком абстрактного класса
     * с абстрактными полями, поэтому обязательно переопределение всех членов класса.
     */
    class MinskEnergyEstablishment : Organization
    {
        public override string Name { get; set; } = "МинскГорЭнерго";

        public override int Id { get; set; } = 3434;

        public override string PhoneNumber { get; set; } = "8(017)353-73-10";

        public override string Address { get; set; } = "г.Минск, Улица Победы 33";

        public override string GetFullInfo()
        {
            return $"Наименование: {Name}\n" +
                $"Номер в реестре: {Id}\n" +
                $"Телефон: {PhoneNumber}\n" +
                $"Адрес: {Address}";
        }
    }
}
