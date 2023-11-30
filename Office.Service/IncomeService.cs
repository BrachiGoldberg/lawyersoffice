
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
    public class IncomeService : IIncomeService
    {
        private readonly IIncomesRepository _incomesRepository;
        public IncomeService(IIncomesRepository incomesRepository)
        {
            _incomesRepository = incomesRepository;
        }

        public Income Delete(int id)
        {
            return _incomesRepository.Delete(id);
        }

        public IEnumerable<Income> Get()
        {
            return _incomesRepository.Get();
        }

        public Income Get(int id)
        {
            return _incomesRepository.Get(id);
        }

        public void Post(Income value)
        {
            _incomesRepository.Post(value);
        }

        public Income Put(int id, Income value)
        {
            return _incomesRepository.Put(id, value);
        }

        public Income Put(int id, int sum)
        {
            return _incomesRepository.Put(id, sum);
        }
    }
}
