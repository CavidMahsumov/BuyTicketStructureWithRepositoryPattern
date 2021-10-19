using BuyTicket.DataAccess.SqlServer;
using BuyTicket.Domain.Additional_Classes;
using BuyTicket.Domain.Entites;
using BuyTicket.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BuyTicket
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AirplaneRepository airplaneRepository = new AirplaneRepository();
        CitiesRepository CitiesRepository = new CitiesRepository();
        SchedulesRepository SchedulesRepository = new SchedulesRepository();
        PilotRepository PilotRepository = new PilotRepository();
        FlightTypesRepository FlightTypesRepository = new FlightTypesRepository();
        TicketRepository TicketRepository = new TicketRepository();
        BuyTicketDbEntities BuyTicketDbEntities = new BuyTicketDbEntities();
        public List<Pilot> pilots { get; set; }
        City City = new City();
        Airplane Airplane = new Airplane();
        Schedule Schedule = new Schedule();

        public MainWindow()
        {
            InitializeComponent();
            pilots = new List<Pilot>();
            
            CitiesCombobox.ItemsSource = CitiesRepository.GetAllData();
            SchedulesComboBox.ItemsSource = SchedulesRepository.GetAllData();
            AirplaneComboBox.ItemsSource = airplaneRepository.GetAllData();

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                
            var currentCities = CitiesCombobox.SelectedItem as City;
                var currentairplanes = BuyTicketDbEntities.Airplanes.Where(a => a.Id == currentCities.AirplaneId);
                var data =ObserverHelper.ToObservableCollection(currentairplanes);
                AirplaneComboBox.ItemsSource = data;
                var currentsch = BuyTicketDbEntities.Schedules.Where(s => s.Id == currentCities.ScheludeId);
                var data2 = ObserverHelper.ToObservableCollection(currentsch);

                SchedulesComboBox.ItemsSource = data2;
                City = currentCities;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AirplaneComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var pilots = PilotRepository.GetAllData();
                var currentAirplane = AirplaneComboBox.SelectedItem as Airplane;
                var currentpilot = BuyTicketDbEntities.Pilots.FirstOrDefault(a => a.Id == currentAirplane.PilotId);

                NameTxtBlock.Text = currentpilot.Name;
                SurnameTxtBlock.Text = currentpilot.Surename;
                Airplane = currentAirplane;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         

        }

        private void PurchaseButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ticket Purchased");
            ShowTicket showTicket = new ShowTicket();
            showTicket.Listbox1.Items.Add(
                new Ticket
                {
                    Airplane = Airplane,
                    AirplaneId = Airplane.Id,
                    Schedule = Schedule,
                     ScheludeId=Schedule.Id,
                      City=City,
                       CityId=City.Id,
                        
                }
                ) ;
            MainGrid.Children.Add(showTicket);
        }

        private void SchedulesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var curretnsch = SchedulesComboBox.SelectedItem as Schedule;
            Schedule = curretnsch;
        }
    }
}
