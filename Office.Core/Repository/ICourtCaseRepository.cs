using Office.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Office.Core.Repository
{
    public interface ICourtCaseRepository
    {
        IEnumerable<CourtCase> Get();

        IEnumerable<CourtCase> Get(DateTime date);

        CourtCase Get(int id);

        void Post(CourtCase value);

        CourtCase Put(int id, CourtCase value);

        CourtCase Put(int id, CourtStatus status);
    }
}
