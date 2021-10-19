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
        BuyTicketDbEntities context = new BuyTicketDbEntities();
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
            var tickets = from a in context.Tickets select a;
            return new ObservableCollection<Ticket>(tickets);
        }

        public Ticket GetData(int id)
        {
            var ticket = context.Tickets.FirstOrDefault(a => a.Id == id);
            return ticket;
        }

        public void UpdateData(Ticket data)
        {
            throw new NotImplementedException();
        }
    }
}
