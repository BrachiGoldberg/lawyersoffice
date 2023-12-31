
using CsvHelper;
using Office.Core.Entites;
using Office.Core.Repository;
using System.Globalization;

namespace Office.Data.Repository
{
    public class CostumerRepository : ICostumerRepository
    {
        private readonly DataContext _data;
        static private int _id;
        public CostumerRepository(DataContext data)
        {
            _data = data;
          //  _id = _data.Costumers.Max<Costumer>(x => x.Id) + 1;
        }

        public IEnumerable<Costumer> Get()
        {
            return _data.Costumers;
        }

        public Costumer Get(int id)
        {
            return _data.Costumers.Find(id);
        }

        public void Post(Costumer value)
        {
            _data.Costumers.Add(new Costumer()
            {
              //  Id = _id++,
                FirstName = value.FirstName,
                LastName = value.LastName,
                Address = value.Address,
                PhoneNumber = value.PhoneNumber,
                Email = value.Email,
                Whatsapp = value.Whatsapp
            });
        }



        public Costumer Put(int id, Costumer value)
        {
            Costumer temp = _data.Costumers.Find(id);
            if (temp != null)
            {
                temp.FirstName = value.FirstName;
                temp.LastName = value.LastName;
                temp.Address = value.Address;
                temp.PhoneNumber = value.PhoneNumber;
                temp.Email = value.Email;
                temp.Whatsapp = value.Whatsapp;

                return temp;
            }
            return null;
        }
    }
}

