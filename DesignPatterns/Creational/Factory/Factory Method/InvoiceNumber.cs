namespace DesignPatterns.Creational.Factory.Factory_Method
{
    public class InvoiceNumber
    {
        public static InvoiceNumber NewInvoiceNumberCustomer(int year, int month, int customerNumber)
        {
            return new InvoiceNumber(year, month, customerNumber, 'C');
        }

        public static InvoiceNumber NewInvoiceNumberMerchant(int year, int month, int customerNumber)
        {
            return new InvoiceNumber(year, month, customerNumber, 'M');
        }

        private InvoiceNumber(int year, int month, int customerNumber, char type)
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
    }
}