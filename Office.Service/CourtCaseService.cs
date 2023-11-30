using Office.Core.Entites;
using Office.Core.Repository;
using Office.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office.Service
{
    public class CourtCaseService : ICourtCaseService
    {
        private readonly ICourtCaseRepository _courtCaseRepository;

        public CourtCaseService(ICourtCaseRepository courtCaseRepository)
        {
            _courtCaseRepository = courtCaseRepository;
        }

        public IEnumerable<CourtCase> Get()
        {
            return _courtCaseRepository.Get();
        }

        public IEnumerable<CourtCase> Get(DateTime date)
        {
            return _courtCaseRepository.Get(date);
        }

        public CourtCase Get(int id)
        {
            return _courtCaseRepository.Get(id);
        }

        public void Post(CourtCase value)
        {
            _courtCaseRepository.Post(value);
        }

        public CourtCase Put(int id, CourtCase value)
        {
            return _courtCaseRepository.Put(id, value);
        }

        public CourtCase Put(int id, CourtStatus status)
        {
            return _courtCaseRepository.Put(id, status);
        }
    }
}
