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
using System.Windows.Shapes;
using WpfApp1.Data;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public DateTime Day { get; set; }
        public decimal Temperature { get; set; }
        public Precipitation Precipitation { get; set; }
        public AddWindow()
        {
            InitializeComponent();
            PrecipitationTb.ItemsSource = Data.DataContext.Precipitations;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            var s = DayTb.Text.Split(".");
            Day = new DateTime(Convert.ToInt32(s[2]), Convert.ToInt32(s[1]), Convert.ToInt32(s[0]));
            Temperature = Convert.ToDecimal(TemperatureTb.Text);
            Precipitation = (Precipitation)PrecipitationTb.SelectedItem;
            Close();
        }
    }
}
