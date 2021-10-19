using BuyTicket.Domain.Abstraction;
using BuyTicket.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyTicket.DataAccess.SqlServer
{
    public class PilotRepository : IPilotRepository
    {
        BuyTicketDbEntities context = new BuyTicketDbEntities();
        public void AddData(Pilot data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Pilot data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Pilot> GetAllData()
        {
            var types = from a in context.Pilots select a;
            return new ObservableCollection<Pilot>(types);
        }

        public Pilot GetData(int id)
        {
            var Pilot = context.Pilots.FirstOrDefault(a => a.Id == id);
            return Pilot;
        }

        public void UpdateData(Pilot data)
        {
            throw new NotImplementedException();
        }
    }
}
