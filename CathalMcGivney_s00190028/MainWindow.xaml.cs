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

namespace CathalMcGivney_s00190028
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PhoneData db = new PhoneData();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, world!");
            Phone p1 = new Phone( "Samsung S20", 500.0m, "Android", "/images/Android", "/images/s20.jpg");
            p1.IncreasePrice(12.5);

            MessageBox.Show("Phone ! " + p1.Price);


            var query = from p in db.Phones
                        select p;


            List<Phone> phones = new List<Phone>();

            phones.Add(new Phone("Samsung S20", 500.0m, "Android", "/images/android.png", "/images/s20.jpg"));
            phones.Add(new Phone("htc", 530.0m, "Android", "/images/android.png", "/images/s20.jpg"));

            try
            {
                Lbx_Phones.ItemsSource = phones;
            }
            catch( Exception ee )
            {
                MessageBox.Show( ee.Message );
            }
            
            // Lsb_data.SelectedItem = 0;


        }
    }
}
