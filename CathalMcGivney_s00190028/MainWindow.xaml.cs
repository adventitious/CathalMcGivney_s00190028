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
            var query = from p in db.Phones
                        select p;

            Lbx_Phones.ItemsSource = query.ToList();
        }

        private void Lbx_Phones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phone phone = (Phone)Lbx_Phones.SelectedItem;

            Txb_price.Text = phone.Price.ToString();

            try
            {
                Uri uri = new Uri("pack://application:,,," + phone.Phone_Image);

                // MessageBox.Show("Phone ! " + uri);
                Img_Phone.Source = new BitmapImage(uri);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
