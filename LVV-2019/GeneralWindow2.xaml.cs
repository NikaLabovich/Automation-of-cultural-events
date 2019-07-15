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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LVV_2019
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class GeneralWindow2 : Window
    {
        public GeneralWindow2()
        {
            InitializeComponent();

            Label1.Content = Current.Users.FirstName + " " + Current.Users.LastName + "!";
            FirsName.Text = Current.Users.FirstName;
            LastName.Text = Current.Users.LastName;
            Birthday.Text = Current.Users.Birthday.ToString();
            Users user = MainWindow.db.Users.Find(Current.Users.Id);
            var userAddress = MainWindow.db.Addresses.Where(p => p.Id == user.AddressId).First();
            Address.Text = userAddress.ToString();
            Users user2 = MainWindow.db.Users.Find(Current.Users.Id);
            List<Interests> currentInterests = new List<Interests>();
            foreach (var ui in MainWindow.db.UserInterests)
            {
                if (ui.UserId == Current.Users.Id) {
                    currentInterests.Add(ui.Interests);
                }
            } 
            //var userInterests = MainWindow.db.UserInterests.Where(p => p.UserId == user.Id);
            foreach (Interests p in currentInterests)
            {
                Interests.Text += " " + (p.Name.ToString());
            }
            //Interests.Text = currentInterests.ToString();
        }

        //public static Users CurrentUser { get; private set; }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            forProfile.Visibility = Visibility.Visible;
            forEvents.Visibility = Visibility.Hidden;
            forRec.Visibility = Visibility.Hidden;
            forRating.Visibility = Visibility.Hidden;
            forEventList.Visibility = Visibility.Hidden;

            Users user = MainWindow.db.Users.Find(Current.Users.Id);
            var userEvents = MainWindow.db.UserEvents.Where(p => p.UserId == user.Id);
            List<Events> listOfEvents = new List<Events>();
            foreach (var events in userEvents)
            {
                listOfEvents.Add(events.Events);
            }
            MyDataGrid.ItemsSource = listOfEvents.OrderByDescending(p => p.Date);


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            forProfile.Visibility = Visibility.Hidden;
            forEvents.Visibility = Visibility.Hidden;
            forRec.Visibility = Visibility.Visible;

            Users user = MainWindow.db.Users.Find(Current.Users.Id);
            var listOfCurrentUserInterests = MainWindow.db.UserInterests.Where(p => p.UserId == user.Id);
            var listOfUserInterests = new List<Interests>();
            foreach (var ui in listOfCurrentUserInterests)
            {
                listOfUserInterests.Add(ui.Interests);
            }
            var listOfEvents = new List<Events>();
            foreach (var interest in listOfUserInterests)
            {
                foreach (var events in MainWindow.db.Events)
                {
                    if (events.Interests.Id == interest.Id)
                    {
                        listOfEvents.Add(events);
                    }
                }
            }
            EventsRecommendedDataGrid.ItemsSource = listOfEvents;

            //Users user = MainWindow.db.Users.Find(Current.Users.Id);
            //List<Events> listOfEvents = new List<Events>();

            //var userInterests = MainWindow.db.UserInterests.Where(p => p.UserId == user.Id);
            //var eventsTypeList = MainWindow.db.Events.Where(p => p.InterestId ==);
            //List<Events> listOfEvents = new List<Events>();
            //foreach (var events in eventsTypeList)
            //{
            //    listOfEvents.Add(events.Events);
            //}
            //EventsListDataGrid.ItemsSource = listOfEvents.OrderByDescending(p => p.Date);

            //var interests = MainWindow.db.Interests.Where(p => p.Name == "Cinema").First();
            //var listOfEvents = MainWindow.db.Events.Where(p => p.InterestId == interests.Id);
            //List<Places> listOfPlaces = new List<Places>();
            //foreach (var events in listOfEvents)
            //{
            //    listOfPlaces.Add(events.Places);
            //}

            forRating.Visibility = Visibility.Hidden;
            forEventList.Visibility = Visibility.Hidden;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            forProfile.Visibility = Visibility.Hidden;
            forRec.Visibility = Visibility.Hidden;
            forEvents.Visibility = Visibility.Visible;
            forRating.Visibility = Visibility.Hidden;
            forEventList.Visibility = Visibility.Hidden;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            forProfile.Visibility = Visibility.Hidden;
            forRec.Visibility = Visibility.Hidden;
            forEvents.Visibility = Visibility.Hidden;
            forRating.Visibility = Visibility.Visible;
            forEventList.Visibility = Visibility.Hidden;

            Dictionary<Events, int> dict = new Dictionary<Events, int>();
            foreach (var ue in MainWindow.db.UserEvents)
            {
                if (!dict.ContainsKey(ue.Events))
                {
                    dict.Add(ue.Events, MainWindow.db.UserEvents.Where(p => p.EventId == ue.EventId).Count());
                }
            }            
            EventsRatingDataGrid.ItemsSource = dict.OrderByDescending(p=>p.Value);            
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            forProfile.Visibility = Visibility.Hidden;
            forRec.Visibility = Visibility.Hidden;
            forEvents.Visibility = Visibility.Hidden;
            forRating.Visibility = Visibility.Hidden;
            forEventList.Visibility = Visibility.Visible;

            Users user = MainWindow.db.Users.Find(Current.Users.Id);
            var userEvents = MainWindow.db.UserEvents.Where(p => p.UserId == user.Id);
            List<Events> listOfEvents = new List<Events>(); 
            foreach (var events in userEvents)
            {
                listOfEvents.Add(events.Events);
            }
            EventsListDataGrid.ItemsSource = listOfEvents.OrderByDescending(p=>p.Date);

            //List<Events> listOfEvents = new List<Events>();
            //foreach (var ue in MainWindow.db.UserEvents)
            //{
            //   // listOfEvents.Add(MainWindow.db.UserEvents.Where(p=>p.EventId == ue.EventId));
            //}

            //EventsRecommendedDataGrid.ItemsSource = listOfEvents;
        }

        private bool IsOpened { get; set; }
        private bool IsOpenedd { get; set; }

        private async void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            IsOpened = !IsOpened;
            if (IsOpened)
            {
                foreach (Grid grid in StackPanel.Children)
                {
                    Button button = grid.Children[1] as Button;
                    button.Visibility = Visibility.Visible;
                }
                for (int i = 0; i <= 150; i += 5)
                {
                    foreach (Grid grid in StackPanel.Children)
                    {
                        Button button = grid.Children[1] as Button;
                        button.Width = i;
                    }
                    await Task.Delay(1);
                }
            }
            else
            {
                for (int i = 150; i >= 0; i -= 5)
                {
                    foreach (Grid grid in StackPanel.Children)
                    {
                        Button button = grid.Children[1] as Button;
                        button.Width = i;
                    }
                    await Task.Delay(1);
                }
                foreach (Grid grid in StackPanel.Children)
                {
                    Button button = grid.Children[1] as Button;
                    button.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void SelectCinemaButton(object sender, RoutedEventArgs e)
        {
            var interests = MainWindow.db.Interests.Where(p => p.Name == "Cinema").First();
            var listOfEvents = MainWindow.db.Events.Where(p => p.InterestId == interests.Id);
            List<Places> listOfPlaces = new List<Places>();
            foreach (var events in listOfEvents)
            {
                listOfPlaces.Add(events.Places);
            }
            ComboBoxPlaces.ItemsSource = listOfPlaces;
            ComboBoxPlaces.SelectedIndex = 0;
        }

        private void SelectTheaterButton(object sender, RoutedEventArgs e)
        {
            var interests = MainWindow.db.Interests.Where(p => p.Name == "Theater").First();
            var listOfEvents = MainWindow.db.Events.Where(p => p.InterestId == interests.Id);
            List<Places> listOfPlaces = new List<Places>();
            foreach (var events in listOfEvents)
            {
                listOfPlaces.Add(events.Places);
            }
            ComboBoxPlaces.ItemsSource = listOfPlaces;
            ComboBoxPlaces.SelectedIndex = 0;
        }

        private void SelectExibitionButton(object sender, RoutedEventArgs e)
        {
            var interests = MainWindow.db.Interests.Where(p => p.Name == "Art").First();
            var listOfEvents = MainWindow.db.Events.Where(p => p.InterestId == interests.Id);
            List<Places> listOfPlaces = new List<Places>();
            foreach (var events in listOfEvents)
            {
                listOfPlaces.Add(events.Places);
            }
            ComboBoxPlaces.ItemsSource = listOfPlaces;
            ComboBoxPlaces.SelectedIndex = 0;
        }

        private void SelectSportsButton(object sender, RoutedEventArgs e)
        {
            var interests = MainWindow.db.Interests.Where(p => p.Name == "Sport").First();
            var listOfEvents = MainWindow.db.Events.Where(p => p.InterestId == interests.Id);
            List<Places> listOfPlaces = new List<Places>();
            foreach (var events in listOfEvents)
            {
                listOfPlaces.Add(events.Places);
            }
            ComboBoxPlaces.ItemsSource = listOfPlaces;
            ComboBoxPlaces.SelectedIndex = 0;
        }

        private void SelectConcertsButton(object sender, RoutedEventArgs e)
        {
            var interests = MainWindow.db.Interests.Where(p => p.Name == "Music").First();
            var listOfEvents = MainWindow.db.Events.Where(p => p.InterestId == interests.Id);
            List<Places> listOfPlaces = new List<Places>();
            foreach (var events in listOfEvents)
            {
                listOfPlaces.Add(events.Places);
            }
            ComboBoxPlaces.ItemsSource = listOfPlaces;
            ComboBoxPlaces.SelectedIndex = 0;
        }

        private void SelectCoffeeButton(object sender, RoutedEventArgs e)
        {
            var interests = MainWindow.db.Interests.Where(p => p.Name == "Coffee").First();
            var listOfEvents = MainWindow.db.Events.Where(p => p.InterestId == interests.Id);
            List<Places> listOfPlaces = new List<Places>();
            foreach (var events in listOfEvents)
            {
                listOfPlaces.Add(events.Places);
            }
            ComboBoxPlaces.ItemsSource = listOfPlaces;
            ComboBoxPlaces.SelectedIndex = 0;
        }

        private void ComboBoxPlaces_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxPlaces.SelectedItem != null)
            {
                MainWindow.db.Places.Load();
                MainWindow.db.Interests.Load();
                MainWindow.db.Events.Load();
                var listOfEvents = MainWindow.db.Events.Local.Where(p=>p.Places.Name == ComboBoxPlaces.SelectedItem.ToString()).ToList();
                DataGridEvents.ItemsSource = listOfEvents;
            }
        }

        private void SubscribeButton(object sender, RoutedEventArgs e)
        {
            if (DataGridEvents.SelectedItem != null)
            {
                Users user = MainWindow.db.Users.Find(Current.Users.Id);
                Events events = MainWindow.db.Events.Find(((Events)DataGridEvents.SelectedItem).Id);
                UserEvents ue = new UserEvents()
                {
                    Users = user, Events = events
                };
                MainWindow.db.UserEvents.Add(ue);
                //events.Count++;
                //MainWindow.db.Entry(events).State = EntityState.Modified;
                MainWindow.db.SaveChanges();
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("You must select event first", "Error");
            }
        }
           

            private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            //foreach (Interests interest in MainWindow.db.Interests)
            //{
            //    ColumnDefinition columnDefinition = new ColumnDefinition();
            //    forEvents.ColumnDefinitions.Add(columnDefinition);
            //    Button button1 = new Button();
            //    button1.Content = interest.Name;
            //    button1.Tag = interest.Id;
            //    Grid.SetColumn(button1, forEvents.ColumnDefinitions.Count - 1);
            //    button1.Style = (Style)Application.Current.FindResource("ButtonStyle3");
            //    forEvents.Children.Add(button1);
            //    button1.Click += (sender1, e1) =>
            //    {
            //        ListBox1.ItemsSource = MainWindow.db.Places.Where(p => p.);
            //    };
            //}
            
        }

        private static void ShowLoader()
        {
            LoadingWindow loader = new LoadingWindow();
            loader.ShowDialog();
            loader.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
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

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (EventsRatingDataGrid.SelectedItem != null)
            {
                Users user = MainWindow.db.Users.Find(Current.Users.Id);
                Events events = new Events(); 
                KeyValuePair<Events,int> x = (KeyValuePair<Events, int>) EventsRatingDataGrid.SelectedItem;
                events = x.Key;
                Events currentEvent = MainWindow.db.Events.Find(events.Id);
                if (MainWindow.db.UserEvents.Where(p => p.EventId == currentEvent.Id && p.UserId == user.Id).Count() > 0)
                {
                    MessageBox.Show("You are already subscribed on this event", "Oops");
                    EventsRatingDataGrid.SelectedItem = null;
                }
                else
                {
                    UserEvents ue = new UserEvents()
                    {
                        Users = user,
                        Events = currentEvent
                    };
                    MainWindow.db.UserEvents.Add(ue);
                    MainWindow.db.SaveChanges();
                    MessageBox.Show("Success");
                    EventsRatingDataGrid.SelectedItem = null;
                }
            }
            else
            {
                MessageBox.Show("You must select event first", "Error");
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (EventsListDataGrid.SelectedItem != null)
            {
                Users user = MainWindow.db.Users.Find(Current.Users.Id);
                var result = MainWindow.db.Events.SingleOrDefault(b => b.Id == ((Events)EventsListDataGrid.SelectedItem).Id);
                UserEvents ue = new UserEvents()
                {
                    Users = user,
                    Events = result
                };
                var resultFinish = MainWindow.db.UserEvents.FirstOrDefault((u) => u.UserId == user.Id && u.EventId == ue.Events.Id);
                if (result!=null)
                {
                    MainWindow.db.UserEvents.Remove(resultFinish);
                    MainWindow.db.SaveChanges();
                    MessageBox.Show("Success");

                }
                else
                {
                    MessageBox.Show("error");
                }
                //Events events = MainWindow.db.Events.Find(((Events)EventsListDataGrid.SelectedItem).Id);
              


                //MainWindow.db.UserEvents.Remove(events);
                //events.Count++;
                //MainWindow.db.Entry(events).State = EntityState.Modified;
            }
            else
            {
                MessageBox.Show("You must select event first", "Error");
            }
        }
    }
}