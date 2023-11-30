using Office.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office.Core.Services
{
    public interface ICostumerService
    {
        IEnumerable<Costumer> Get();

        public Costumer Get(int id);

        void Post(Costumer value);

        Costumer Put(int id, Costumer value);
    }
}
