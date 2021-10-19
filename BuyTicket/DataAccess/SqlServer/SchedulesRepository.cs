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
    public class SchedulesRepository : ISchedulesRepository
    {
        BuyTicketDbEntities context = new BuyTicketDbEntities();
        public void AddData(Schedule data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Schedule data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Schedule> GetAllData()
        {
            var scs = from a in context.Schedules select a;
            return new ObservableCollection<Schedule>(scs);
        }

        public Schedule GetData(int id)
        {
            var Sch = context.Schedules.FirstOrDefault(a => a.Id == id);
            return Sch;
        }

        public void UpdateData(Schedule data)
        {
            throw new NotImplementedException();
        }
    }
}
