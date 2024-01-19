using Microsoft.VisualBasic;
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
        public ObservableCollection<Punkty> Punkciki { get; set; }
        public int LiczbaKosci { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            LiczbaKosci = 5;
            Rezultaty = new ObservableCollection<Kosc>();
            Punkciki = new ObservableCollection<Punkty>();
            przygotujPunkty();
            przygotujKosci();
        }
        private void przygotujPunkty()
        {
            Punkciki.Clear();
            Punkciki.Add(new Punkty("jedynki"));
            Punkciki.Add(new Punkty("dwójki"));
            Punkciki.Add(new Punkty("trójki"));
            Punkciki.Add(new Punkty("czwórki"));
            Punkciki.Add(new Punkty("piątki"));
            Punkciki.Add(new Punkty("szóstki"));
            Punkciki.Add(new Punkty("para"));
            Punkciki.Add(new Punkty("dwie pary"));
            Punkciki.Add(new Punkty("trójka"));
            Punkciki.Add(new Punkty("kareta"));
            Punkciki.Add(new Punkty("poker"));
            Punkciki.Add(new Punkty("mały strit"));
            Punkciki.Add(new Punkty("duży strit"));
            Punkciki.Add(new Punkty("szansa"));
        }
        private void rzuc_btn_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();  
            foreach(Kosc k in Rezultaty)
            {
                if(!k.CzyZaznaczona)
                k.Wartosc = random.Next(1, 7);
            }
            wyswietlPunkty();

        }
        private void wyswietlPunkty()
        {
            for(int i = 0; i < 6; i++)
            {
                if (!Punkciki[i].Zatwierdzone)
                     Punkciki[i].Liczbapunktow = szkola(i+1);
            }
            
            if (!Punkciki[13].Zatwierdzone)
                Punkciki[13].Liczbapunktow = sumaWszystkich();
        }

        private int szkola(int liczba)
        {
            int ile = 0;
            foreach(Kosc k in Rezultaty)
            {
                if(k.Wartosc == liczba)
                {
                    ile++;
                }
            }
            return (ile-3)*liczba;
        }
        private int sumaWszystkich()
        {
            //obliczamy szansę
            //sumujemy wszystkie wartości na kosciach
            int suma = 0;
            foreach(Kosc k in Rezultaty)
            {
                suma += k.Wartosc;
            }
            return suma;
        }
        private void przygotujKosci()
        {
            Rezultaty.Clear();

            for (int i = 0; i < LiczbaKosci; i++)
            {
                Rezultaty.Add(new Kosc());
            }
        }

        private void czysc_btn_Click(object sender, RoutedEventArgs e)
        {
            przygotujKosci();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Button button  = sender as Button;
            Button button = (Button)sender;
            Kosc k = (Kosc)button.DataContext;
            k.CzyZaznaczona = !k.CzyZaznaczona;
        }
    }
}
