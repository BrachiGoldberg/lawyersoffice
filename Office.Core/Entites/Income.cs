namespace Office.Core.Entites
{
    public enum PaymentMethod { CASH, BANKTRANSFER, CHECK, }

    public class Income
    {
        public int Code { get; set; }

        public int Sum { get; set; }

        public DateTime Date { get; set; }

        public PaymentMethod PaymentBy { get; set; }
        public int CourtCaseId { get; set; }

        public virtual bool Equals(Object? obj)
        {
            if(this.Code == ((Income)obj).Code)
                return true;
            return false;
        }
    }
}
