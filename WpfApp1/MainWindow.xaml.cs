using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Data;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Weather> weathers;
        private List<string> sortNamesList;
        public MainWindow()
        {
            InitializeComponent();
            sortNamesList =
            [
                "По дням",
                "По дням наоборот",
                "По температуре",
                "По температуре наоборот",
            ];
            weathers = Data.DataContext.Weathers;
            LstView.ItemsSource = weathers;
            FilterCB.ItemsSource = Data.DataContext.Precipitations;
            SorterCB.ItemsSource = sortNamesList;
        }

        private void SerchTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filter = weathers.Where(x => 
                x.Day.ToString().Contains(SerchTB.Text) 
                || x.Precipitation.Title.ToString().Contains(SerchTB.Text)
                || x.Temperature.ToString().Contains(SerchTB.Text)).ToList();
            LstView.ItemsSource = filter;
            LstView.Items.Refresh();
        }

        private void FilterCB_DropDownClosed(object? sender, EventArgs e)
        {
            var filter = weathers.Where(x => 
                x.Precipitation == (Precipitation)FilterCB.SelectedItem).ToList();
            LstView.ItemsSource = filter;
            LstView.Items.Refresh();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            weathers = Data.DataContext.Weathers;
            FilterCB.SelectedItem = null;
            LstView.ItemsSource = weathers;
            LstView.Items.Refresh();
        }

        private void SorterCB_DropDownClosed(object? sender, EventArgs e)
        {
            List<Weather> filter = null;
            switch (SorterCB.SelectedItem)
            {
                case "По дням":
                    filter = ((List<Weather>)LstView.ItemsSource).OrderBy(x => x.Day).ToList();
                    break;
                case "По дням наоборот": filter = ((List<Weather>)LstView.ItemsSource).OrderByDescending(x => x.Day).ToList();
                    break;
                case "По температуре": filter = ((List<Weather>)LstView.ItemsSource).OrderBy(x => x.Temperature).ToList();
                    break;
                case "По температуре наоборот": filter = ((List<Weather>)LstView.ItemsSource).OrderByDescending(x => x.Temperature).ToList();
                    break;
            }
            if(filter is null) return;
            LstView.ItemsSource = filter;
            LstView.Items.Refresh();
        }

        private void DeleteMI_Click(object sender, RoutedEventArgs e)
        {
            var selected = (Weather)LstView.SelectedItem;
            Data.DataContext.Weathers.Remove(selected);
            weathers = Data.DataContext.Weathers;
            LstView.Items.Refresh();
        }

        private void AddButtonClick(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            addWindow.ShowDialog();
            if (addWindow.DialogResult != true) return;
            Data.DataContext.Weathers.Add(new Weather(addWindow.Temperature, addWindow.Day, addWindow.Precipitation));
            weathers = Data.DataContext.Weathers;
            LstView.ItemsSource = weathers;
            SorterCB.SelectedItem = null;
            FilterCB.SelectedItem = null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var lst = Data.DataContext.Weathers;
            string average = $"Среднее значение температуры: {lst.Average(x => x.Temperature).ToString().Substring(0, 5)}\n";
            string Max = $"Максимальное значение температуры: {lst.Max(x => x.Temperature)}\n";
            string Min = $"Минимальное значение температуры: {lst.Min(x => x.Temperature)}\n";
            var dict = new Dictionary<decimal, int>();
            foreach (var d in lst)
            {
                if(dict.ContainsKey(d.Temperature))
                {
                    dict[d.Temperature]++;
                }
                else
                {
                    dict.Add(d.Temperature, 1);
                }
            }
            var keyOfMaxValue =
                dict.MaxBy(dict => dict.Value).Key;
            List<Weather> repeated = lst.Where(x => x.Temperature == keyOfMaxValue).ToList();
            string maxRepeated = $"Наиболее повторяемая температура: {keyOfMaxValue}, она была в дни: ";
            foreach (Weather weather in repeated)
            {
                maxRepeated += weather.Day+", ";
            }

            string anomaly = "Аномальные изменения температуры: ";
            for (int i = 0; i < lst.Count-1; i++)
            {
                if (weathers[i + 1].Temperature >= weathers[i].Temperature + 10 ||
                    weathers[i + 1].Temperature <= weathers[i].Temperature - 10)
                {
                    anomaly +=
                        $"[Было: день: {weathers[i].Day} температура: {weathers[i].Temperature}, стало: день: {weathers[i+1].Day} температура: {weathers[i+1].Temperature}, Разница: {Math.Abs(weathers[i + 1].Temperature - weathers[i].Temperature)} градусов]";
                }
            }
            MessageBox.Show(average+Max+Min+maxRepeated+"\n"+anomaly);
        }
    }
}