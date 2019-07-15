using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
       

        public Registration()
        {
            InitializeComponent();
        }

        private void Register()
        {
            try
            {
                string username = TextBox.Text;
                string password = PasswordBox.Password;
                

                Credentials registerModel = new Credentials()
                {
                    Username = username,
                    Password = password,                      
                };

                if (Validtion.TryValidateObject(registerModel, TextBox, PasswordBox))

                {
                    string hash = Hash(PasswordBox.Password);
                    //bool isAdmin = (bool)isAdminCheckBox.IsChecked;

                    using (My_KPEntities  db = new My_KPEntities())
                    {
                        var sameUser = db.Users.FirstOrDefault(u => u.Credentials.Username == TextBox.Text);
                        if (sameUser == null)
                        {

                            Credentials credentials = new Credentials() { Username = TextBox.Text, Password = Hash(PasswordBox.Password) };
                            Addresses addresses = new Addresses() { City = City.Text, Street = Street.Text, House = House.Text };
                            Users user = db.Users.Add(new Users() { Credentials = credentials, LastName = LastNameBox.Text, FirstName = FirstNameBox.Text, Addresses = addresses, Birthday = BirthdayBox.SelectedDate.Value, RoleId = 1 });
                            for (int i = 0; i<WrapPanel.Children.Count; i++)
                            {
                               CheckBox  checkBox = (CheckBox)WrapPanel.Children[i] ;
                                if (checkBox.IsChecked == true)
                                {
                                    db.UserInterests.Add(new UserInterests() { UserId = user.Id, InterestId = i + 1 });
                                }
                            }
                           db.SaveChanges();                                                     
                           
                        }
                        else
                        {
                            MessageBox.Show("user with the same name already exists");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
            }
        }

        public void DatePicker_SelectedDateChanged(object sender,
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

        public string Hash(string password)
        {
            var bytes = Encoding.UTF8.GetBytes(password);
            byte[] hashbytes = SHA512.Create().ComputeHash(bytes);
            return Convert.ToBase64String(hashbytes).Substring(0, 40);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            // Current.Users = user;

            Hide();
            Thread myThread = new Thread(new ThreadStart(ShowLoader));
            myThread.SetApartmentState(ApartmentState.STA);
            myThread.Start();
            Thread.Sleep(2000);
            myThread.Abort();
            Register();
            MainWindow mainw = new MainWindow();
            mainw.Show();

        }

        //Hide();
        //Thread myThread = new Thread(new ThreadStart(ShowLoader));
        //myThread.SetApartmentState(ApartmentState.STA);
        //myThread.Start();
        //Thread.Sleep(2000);
        //myThread.Abort();

        //GeneralWindow2 gen2 = new GeneralWindow2();
        //gen2.Show();
    }
    }

