using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfAppKosci3Ppiatek_Xaml
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Kosc> Rezultaty { get; set; }
        public int LiczbaKosci { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            LiczbaKosci = 5;
            Rezultaty = new ObservableCollection<Kosc>();
        }

        private void rzuc_btn_Click(object sender, RoutedEventArgs e)
        {
           
            Random random = new Random();  
            foreach(Kosc k in Rezultaty)
            {
                k.Wartosc = random.Next(1, 7);
            }

        }

        private void czysc_btn_Click(object sender, RoutedEventArgs e)
        {
            Rezultaty.Clear();
            
            for (int i = 0; i < LiczbaKosci; i++)
            {
                Rezultaty.Add(new Kosc());
            }
        }
    }
}
