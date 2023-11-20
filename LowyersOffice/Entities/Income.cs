namespace LowyersOffice.Entities
{

    public enum PaymentMethod { CASH, BANKTRANSFER, CHECK, }
    public class Income
    {

        public int Code { get; set; }

        public int Sum { get; set; }

        public DateTime Date { get; set; }

        public PaymentMethod PaymentBy { get; set; }
    }
}
