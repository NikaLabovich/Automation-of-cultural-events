using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LVV_2019
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static My_KPEntities db = new My_KPEntities();

        public MainWindow()
        {
            InitializeComponent();

            
                //db.Roles.Add(new Roles() { Role = "Admin"});        
                // db.SaveChanges();
                //Credentials credentials = new Credentials() { Username = "Veronika", Password = Hash("12345") };
                //Addresses addresses = new Addresses() { City = "Minsk", Street = "Kozyrevskaya", House = "16" };
                //db.Users.Add(new Users() { Credentials = credentials, LastName = "Labovitch", FirstName = "Veranika", Addresses = addresses, Birthday = new DateTime(2000, 01, 20), RoleId = 2 });
                //db.SaveChanges();     
        }

        public string Hash(string password)
        {
            var bytes = Encoding.UTF8.GetBytes(password);
            byte[] hashbytes = SHA512.Create().ComputeHash(bytes);
            return Convert.ToBase64String(hashbytes).Substring(0,40);
        }

        private void Authentification()
        {
            //try
            //{
                string username = Textbox.Text;
                string password = Passwordbox.Password;

                Credentials loginModel = new Credentials() { Username = username, Password = password };

                if (Validtion.TryValidateObject(loginModel, Textbox, Passwordbox))
                {
                    string hash = Hash(Passwordbox.Password);
                    using (My_KPEntities db = new My_KPEntities())
                    {
                        var user = db.Users.FirstOrDefault(u => u.Credentials.Username == username);
                        if (user != null)
                        {
                            if (user.Credentials.Password == hash)
                            {                             
                                if (user.RoleId == 2)
                                {
                                    //Current.Users = users; 
                                    Hide();
                                    Thread myThread = new Thread(new ThreadStart(ShowLoader));
                                    myThread.SetApartmentState(ApartmentState.STA);
                                    myThread.Start();
                                    Thread.Sleep(2000);
                                    myThread.Abort();

                                    GeneralWindow gen = new GeneralWindow();
                                    gen.Show();
                                    gen.UserControl1.Minimized = true;
                                    gen.UserControl2.Minimized = true;
                                    // gen.UserControl3.Minimized = true;
                                    //gen.UserControl4.Minimized = true;
                                }
                                else if (user.RoleId == 1)
                                {
                                    Current.Users = user;
                                    Hide();
                                    Thread myThread = new Thread(new ThreadStart(ShowLoader));
                                    myThread.SetApartmentState(ApartmentState.STA);
                                    myThread.Start();
                                    Thread.Sleep(2000);
                                    myThread.Abort();

                                    GeneralWindow2 gen2 = new GeneralWindow2();
                                    gen2.Show();
                                }

                            }
                            else
                            {
                                MessageBox.Show("Wrong password");
                            }
                        }
                        else
                        {
                            MessageBox.Show("such user not found");
                        }
                    }
                }
            //}
            //catch (exception ex)
            //{
            //    messagebox.show(ex.message, "ошибка");
            //}
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Authentification();
            //string hash = Hash(Passwordbox.Password);
            //Users users = db.Users.FirstOrDefault(p => p.Credentials.Username == Textbox.Text && p.Credentials.Password == hash);
            
            //    if (users.RoleId == 2)
            //    {
            //        //Current.Users = users; 
            //        Hide();
            //        Thread myThread = new Thread(new ThreadStart(ShowLoader));
            //        myThread.SetApartmentState(ApartmentState.STA);
            //        myThread.Start();
            //        Thread.Sleep(2000);
            //        myThread.Abort();

            //        GeneralWindow gen = new GeneralWindow();
            //        gen.Show();
            //        gen.UserControl1.Minimized = true;
            //        gen.UserControl2.Minimized = true;
            //        // gen.UserControl3.Minimized = true;
            //        //gen.UserControl4.Minimized = true;
            //    }
            //    else if (users.RoleId == 1)
            //    {
            //        Current.Users = users;
            //        Hide();
            //        Thread myThread = new Thread(new ThreadStart(ShowLoader));
            //        myThread.SetApartmentState(ApartmentState.STA);
            //        myThread.Start();
            //        Thread.Sleep(2000);
            //        myThread.Abort();

            //        GeneralWindow2 gen2 = new GeneralWindow2();
            //        gen2.Show();
            //    }
            
            //else
            //{
            //    MessageBox.Show("we don't have account with the same username or password");
            //}
            
        }

        private static void ShowLoader()
        {
            LoadingWindow loader = new LoadingWindow();
            loader.ShowDialog();
            loader.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Hide();
            Thread myThread = new Thread(new ThreadStart(ShowLoader));
            myThread.SetApartmentState(ApartmentState.STA);
            myThread.Start();
            Thread.Sleep(2000);
            myThread.Abort();

            Registration reg = new Registration();
            reg.Show();
            
        }


    }
}
