using Office.Core.Entites;
using Office.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Office.Data.Repository
{
    public class CourtCaseRepository : ICourtCaseRepository
    {
        private readonly DataContext _data;
        private int _id;
        public CourtCaseRepository(DataContext data)
        {
            _data = data;
            _id = 5;
        }
        public IEnumerable<CourtCase> Get()
        {
            return _data.CourtCases;
        }

        public IEnumerable<CourtCase> Get(DateTime date)
        {
            return _data.CourtCases.Where(c => c.OpeningDate.CompareTo(date) >= 0);
        }

        public CourtCase Get(int id)
        {
            return _data.CourtCases.Find(c => c.Code == id);
        }

        public void Post(CourtCase value)
        {
            _data.CourtCases.Add(new CourtCase()
            {
                Code = _id++,
                CourtType = value.CourtType,
                Fees = value.Fees,
                OpeningDate = new DateTime(),
                CourtCaseStatus = value.CourtCaseStatus,
                CostumerStatusOnCourt = value.CostumerStatusOnCourt,
                AmountToPay = value.Fees
            });
        }

        public CourtCase Put(int id, CourtCase value)
        {
            var court = _data.CourtCases.Find(c => c.Code == id);
            if (court != null)
            {
                court.CourtType = value.CourtType;
                court.Fees = value.Fees;
                court.CourtCaseStatus = value.CourtCaseStatus;
                court.CostumerStatusOnCourt = value.CostumerStatusOnCourt;
                court.AmountToPay = value.AmountToPay;
                return court;
            }
            return null;
        }

        public CourtCase Put(int id, CourtStatus status)
        {
            var found = _data.CourtCases.Find(c => c.Code == id);
            if (found != null)
            {
                found.CourtCaseStatus = status;
                return found;
            }
            return null;
        }
    }
}
