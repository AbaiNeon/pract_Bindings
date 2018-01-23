using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
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

namespace pract_Bindings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Сurrency> list1;
        public MainWindow()
        {
            InitializeComponent();

            list1 = new ObservableCollection<Сurrency>();

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://data.egov.kz/api/v2/valutalar_bagamdary4/v239?pretty");

            Stream stream = request.GetResponse().GetResponseStream();
            string html = null;
            using (stream)
            {
                using (StreamReader reader = new StreamReader(stream, Encoding.GetEncoding("utf-8")))
                {
                    html = reader.ReadToEnd();
                }
            }

            list1 = JsonConvert.DeserializeObject<ObservableCollection<Сurrency>>(html);

            listView.ItemsSource = list1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            list1.RemoveAt(0);
        }
    }
}
