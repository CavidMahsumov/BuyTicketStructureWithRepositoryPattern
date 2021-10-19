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
    class CitiesRepository : ICitiesRepository
    {
        BuyTicketDbEntities context = new BuyTicketDbEntities();
        public void AddData(City data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(City data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<City> GetAllData()
        {
            var cities = from a in context.Cities select a;
            return new ObservableCollection<City>(cities);
        }

        public City GetData(int id)
        {
            var city = context.Cities.FirstOrDefault(a => a.Id == id);
            return city;
        }

        public void UpdateData(City data)
        {
            throw new NotImplementedException();
        }
    }
}
