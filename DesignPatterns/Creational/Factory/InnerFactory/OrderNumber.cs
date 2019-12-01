namespace DesignPatterns.Creational.Factory.InnerFactory
{
    public class OrderNumber
    {
        private OrderNumber(int year, int month, int customerNumber, char type)
        {
            this.Year = year;
            this.Month = month;
            this.CustomerNumber = customerNumber;
            this.Type = type;
        }

        public int Year { get; set; }
        public int Month { get; set; }
        public int CustomerNumber { get; set; }
        public char Type { get; set; }

        public override string ToString()
        {
            return $"{Year}{Month}_{CustomerNumber}_{Type}";
        }

        public static class Factory
        {
            public static OrderNumber NewOrderNumberForPerson(int year, int month, int customerNumber)
            {
                return new OrderNumber(year, month, customerNumber, 'P');
            }

            public static OrderNumber NewOrderNumberForCompany(int year, int month, int customerNumber)
            {
                return new OrderNumber(year, month, customerNumber, 'C');
            }
        }
    }
}