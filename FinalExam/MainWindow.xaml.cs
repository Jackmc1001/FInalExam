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

namespace FinalExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RentalData db = new RentalData();
        public MainWindow()
        {
            InitializeComponent();


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //loads listbox with content from database
            var query = from c in db.RentalProperties
                        orderby c.Price ascending
                        select c;
                        

            lbxPropertyList.ItemsSource = query.ToList();
        }

        private void lbxPropertyList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //displays the descriptoon
            RentalProperty r1 = (RentalProperty)lbxPropertyList.SelectedItem;

            var query = (from c in db.RentalProperties
                         where c.ID == r1.ID
                         select c.Description).First();

            tblkDescription.Text = query;
        }

        private void AddWindow_Click(object sender, RoutedEventArgs e)
        {
            //use to load new window
            NewPropert newwindow = new NewPropert();

            newwindow.Show();
        }
    }
}
