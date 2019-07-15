using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace LVV_2019
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl2Edit : UserControl
    {
        public UserControl2Edit()
        {
            InitializeComponent();
            FillComboBox();       
        }
        

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(UserControl2Edit), new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty MinimizedProperty = DependencyProperty.Register("Minimized", typeof(bool), typeof(UserControl2Edit), new PropertyMetadata(false));


        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }
      

        public bool Minimized
        {
            get => (bool)GetValue(MinimizedProperty);
            set
            {
                SetValue(MinimizedProperty, value);
                ToggleMinimize();
            }
        }

        My_KPEntities db = new My_KPEntities();

        private void FillComboBox()
        {
            PlaceBox.ItemsSource = db.Places.ToList();
            TypeBox.ItemsSource = db.Interests.ToList();
        }

     

        private void EditEvent()
        {                        
               Events updateevents = (from m in db.Events where m.Name == NameBox.Text select m).Single();
            //updateevents.Name = "";
            //updateevents.Name = NameBox.Text;
            updateevents.Places.Name = PlaceBox.SelectedItem.ToString();
            updateevents.Date = DateBox.SelectedDate.Value;
            updateevents.InterestId = ((Interests)TypeBox.SelectedItem).Id;
            db.Entry(updateevents).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            //MessageBox.Show(updateevents.Name);
            
            //Events events = db.Events.Update(new Events() { Name = NameBox.Text, Date = DateBox.SelectedDate.Value, PlaceId = ((Places)PlaceBox.SelectedItem).Id, InterestId = ((Interests)TypeBox.SelectedItem).Id });
            //db.SaveChanges();
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void ToggleMinimize()
        {
            Border border = (Border)FindName("Border");
            Grid grid = (Grid)FindName("Grid");
            Path path = (Path)FindName("Path");
            if (Minimized == true)
            {
                // border.Height = grid.RowDefinitions[0].ActualHeight;
                border.Height = grid.RowDefinitions[0].ActualHeight;
                border.Width = 280;
                path.Data = (Geometry)Resources["ArrowLeft"];
            }
            else
            {
                border.Height = double.NaN;
                path.Data = (Geometry)Resources["ArrowDown"];
            }
        }

        private void Path_MouseDown(object sender, MouseButtonEventArgs e)
        {

            Minimized = !Minimized;

            ToggleMinimize();

        }

      

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EditEvent();
        }
    }
}
