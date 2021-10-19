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
    public class AirplaneRepository : IAirplaneRepository
    {
        BuyTicketDbEntities context = new BuyTicketDbEntities();
        public void AddData(Airplane data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Airplane data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Airplane> GetAllData()
        {
            var airplane = from a in context.Airplanes select a;
            return new ObservableCollection<Airplane>(airplane);
        }

        public Airplane GetData(int id)
        {
            var airplane = context.Airplanes.FirstOrDefault(a => a.Id == id);
            return airplane;
        }

        public void UpdateData(Airplane data)
        {
            throw new NotImplementedException();
        }
    }
}
