using Office.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Office.Core.Repository
{
    public interface IIncomesRepository
    {
        IEnumerable<Income> Get();

        Income Get(int id);

        void Post(Income value);

        Income Put(int id, Income value);

        Income Put(int id, int sum);

        Income Delete(int id);
    }
}
