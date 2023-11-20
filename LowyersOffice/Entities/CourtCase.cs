namespace LowyersOffice.Entities
{
    
    public enum CourtCaseType { FAMILY, TAXES, ADMINISTRATIVELAW, REALESTATE, WORKING}
    /*
     FAMILY : משפחה
     TAXES: מיסים
     ADMINISTRATIVELAW: משפט מנהלי
     REALESTATE: נדלן
     WORKING: עבודה
     */

    public enum CourtStatus { ACTIVE, POSIVE}
    
    public enum CostumerStatus { PROSECUTOR, DEFENDANT}
    /*
     PROSECUTOR: תובע
     DEFENDANT: נתבע
     */

    public class CourtCase
    {

        public int Code { get; set; }

        public CourtCaseType CourtType { get; set; }

        public int Fees { get; set; }

        public DateTime OpeningDate { get; set; }

        public DateTime ClosingDate { get; set; }

        public CourtStatus CourtCaseStatus { get; set; }

        public CostumerStatus CostumerStatusOnCourt { get; set; }

        public int AmountToPay { get; set; }

        public CourtCase(int code, CourtCaseType courtType, int fees,DateTime openingDate, CourtStatus courtCaseStatus, CostumerStatus costumerStatusOnCourt, int amountToPay)
        {
            Code = code;
            CourtType = courtType;
            Fees = fees;
            OpeningDate = openingDate;
            CourtCaseStatus = courtCaseStatus;
            CostumerStatusOnCourt = costumerStatusOnCourt;
            AmountToPay = amountToPay;
        }
        public CourtCase()
        {

        }
    }
}
