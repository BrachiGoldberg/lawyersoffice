using Office.Core.Entites;
using Office.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Office.Data.Repository
{
    public class IncomesRepository : IIncomesRepository
    {
        private readonly DataContext _data;
        private int _id;
        public IncomesRepository(DataContext data)
        {
            _data = data;
            _id = 4;
        }
        public Income Delete(int id)
        {
            var income = _data.Incomes.Find(i => i.Code == id);
            if (income != null)
            {
                _data.Incomes.Remove(income);
                return income;
            }
            return null;
        }

        public IEnumerable<Income> Get()
        {
            return _data.Incomes;
        }

        public Income Get(int id)
        {
            return _data.Incomes.Find(i => i.Code == id);
        }

        public void Post(Income value)
        {
            _data.Incomes.Add(new Income()
            { Code = _id++, Date = new DateTime(), 
                PaymentBy = value.PaymentBy, Sum = value.Sum });
        }

        public Income Put(int id, Income value)
        {
            var income = _data.Incomes.Find(i => i.Code == id);
            if (income != null)
            {
                income.Sum = value.Sum;
                income.Date = value.Date;
                income.PaymentBy = value.PaymentBy;
                return income;
            }
            return null;
        }

        public Income Put(int id, int sum)
        {
            var income = _data.Incomes.Find(i => i.Code == id);
            if (income != null)
            {
                income.Sum = sum;
                return income;
            }
            return null;
        }
    }
}
