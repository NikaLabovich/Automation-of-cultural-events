using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LVV_2019
{
    /// <summary>
    /// Interaction logic for GeneralWindow.xaml
    /// </summary>
    public partial class GeneralWindow : Window
    {
        public GeneralWindow()
        {
            InitializeComponent();
            //FillComboBox();

            var allEvents = MainWindow.db.Events;
            List<Events> listOfEvents = new List<Events>();
            foreach (Events events in allEvents)
            {
                listOfEvents.Add(events);
            }
            DataGridEvents.ItemsSource = listOfEvents.OrderByDescending(p => p.InterestId);
        }

       
        My_KPEntities db = new My_KPEntities();

        private void DatePicker_SelectedDateChanged(object sender,
           SelectionChangedEventArgs e)
        {
            // ... Get DatePicker reference.
            var picker = sender as DatePicker;

            // ... Get nullable DateTime from SelectedDate.
            DateTime? date = picker.SelectedDate;
            if (date == null)
            {
                // ... A null object.
                this.Title = "No date";
            }
            else
            {
                // ... No need to display the time.
                this.Title = date.Value.ToShortDateString();
            }
        }

        private static void ShowLoader()
        {
            LoadingWindow loader = new LoadingWindow();
            loader.ShowDialog();
            loader.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Thread myThread = new Thread(new ThreadStart(ShowLoader));
            myThread.SetApartmentState(ApartmentState.STA);
            myThread.Start();
            Thread.Sleep(2000);
            myThread.Abort();            
            MainWindow mainw = new MainWindow();
            mainw.Show();
        }

        private void Button_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //DataGridEvents.ItemsSource = MainWindow.db.Events.ToList();
            //var allEvents = MainWindow.db.Events;
            //List<Events> listOfEvents = new List<Events>();
            //foreach (var events in allEvents)
            //{
            //    listOfEvents.Add(events);
            //}
            //DataGridEvents.ItemsSource = listOfEvents.OrderByDescending(p => p.InterestId);
            //DataGridEvents.update();
            //DataGridEvents.refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var allEvents = MainWindow.db.Events;
            List<Events> listOfEvents = new List<Events>();
            foreach (var events in allEvents)
            {
                listOfEvents.Add(events);
            }
            DataGridEvents.ItemsSource = listOfEvents.OrderByDescending(p => p.InterestId);
        }
    }
}
