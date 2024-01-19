using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppKosci3Ppiatek_Xaml
{
    public class Punkty:NotifyPropertyChanged
    {
        private string _nazwa;

        

        public String Nazwa
        {
            get { return _nazwa; }
            set { _nazwa = value; }
        }

        private int _liczbapunktow;
        public int Liczbapunktow
        {
            get => _liczbapunktow;
            set {
                _liczbapunktow = value;
                OnPropertyChanged();
                    }
        }

        private bool _zatwierdzone;
        public bool Zatwierdzone
        {
            get => _zatwierdzone;
            set
            {
                _zatwierdzone = value;
                OnPropertyChanged();
            }
        }
        public Punkty(string nazwa)
        {
            Nazwa = nazwa;
            Zatwierdzone = false;
            Liczbapunktow = 0;
        }
    }
}
