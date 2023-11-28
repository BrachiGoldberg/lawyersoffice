﻿using LowyersOffice.Controllers;

namespace LowyersOffice.Entities
{
    
    public enum CourtCaseType { FAMILY=1, TAXES, ADMINISTRATIVELAW, REALESTATE, WORKING}
    /*
     FAMILY : משפחה
     TAXES: מיסים
     ADMINISTRATIVELAW: משפט מנהלי
     REALESTATE: נדלן
     WORKING: עבודה
     */

    public enum CourtStatus { ACTIVE = 1, POSIVE}
    
    public enum CostumerStatus { PROSECUTOR = 1, DEFENDANT}
    /*
     PROSECUTOR: תובע
     DEFENDANT: נתבע
     */

    public class CourtCase
    {
        /* באיזה צורה כדאי שההכלה תתבצע: רשימה במחלקהת, או מאפיין */
        public int Code { get; set; }

        public CourtCaseType CourtType { get; set; }

        public int Fees { get; set; }

        public DateTime OpeningDate { get; set; }

        public DateTime ClosingDate { get; set; }

        public CourtStatus CourtCaseStatus { get; set; }

        public CostumerStatus CostumerStatusOnCourt { get; set; }

        public int AmountToPay { get; set; }

        //public int IncomeId{ get; set; }

        public int CostumerId { get; set; }
    }
}
