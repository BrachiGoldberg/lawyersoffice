using Office.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office.Core.Services
{
    public interface ICourtCaseService
    {
        IEnumerable<CourtCase> Get();

        IEnumerable<CourtCase> Get(DateTime date);

        CourtCase Get(int id);

        void Post(CourtCase value);

        CourtCase Put(int id, CourtCase value);

        CourtCase Put(int id, CourtStatus status);
    }
}
