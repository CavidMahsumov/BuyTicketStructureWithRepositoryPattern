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
    public class TicketRepository : ITicketRepository
    {
        public void AddData(Ticket data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Ticket data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Ticket> GetAllData()
        {
            throw new NotImplementedException();
        }

        public Ticket GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Ticket data)
        {
            throw new NotImplementedException();
        }
    }
}
