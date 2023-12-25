using CsvHelper;
using CsvHelper.Configuration.Attributes;
using Newtonsoft.Json.Linq;
using Office.Core.Entites;
using Office.Core.Repository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Office.Data.Repository
{
    public class IncomesRepository : IIncomesRepository
    {
        private readonly DataContext _data;
        static private int _id;
        public IncomesRepository(DataContext data)
        {
            _data = data;
            _id = _data.Incomes.Max<Income>(x=> x.Code) + 1;
        }
        public Income Delete(int id)
        {
            var incomes = Get().ToList();
            var income = _data.Incomes.Find(i => i.Code == id);
            if (income != null)
            {
                var a = incomes.Remove(income);
                using (var writer = new StreamWriter("incomes.csv"))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords<Income>(incomes);
                }
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
            using (var writer = new StreamWriter("incomes.csv", true))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecord<Income>(new Income()
                {
                    Code = _id++,
                    Date = new DateTime(),
                    PaymentBy = value.PaymentBy,
                    Sum = value.Sum
                });
            }
        }

        public Income Put(int id, Income value)
        {
            var incomes = Get();
            var income = _data.Incomes.Find(c => c.Code == id);
            if (income != null)
            {
                income.Sum = value.Sum;
                income.Date = value.Date;
                income.PaymentBy = value.PaymentBy;

                using (var writer = new StreamWriter("incomes.csv"))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords<Income>(incomes);
                }
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
                return Put(id, income);
            }
            return null;
        }

        

    }
}
