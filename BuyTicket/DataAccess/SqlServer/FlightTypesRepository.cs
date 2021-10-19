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
    public class FlightTypesRepository : IFlightRepository
    {
        BuyTicketDbEntities context = new BuyTicketDbEntities();
        public void AddData(FlyType data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(FlyType data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<FlyType> GetAllData()
        {
            var types = from a in context.FlyTypes select a;
            return new ObservableCollection<FlyType>(types);
        }

        public FlyType GetData(int id)
        {
            var type = context.FlyTypes.FirstOrDefault(a => a.Id == id);
            return type;
        }

        public void UpdateData(FlyType data)
        {
            throw new NotImplementedException();
        }
    }
}
