﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppKosci3Ppiatek_Xaml
{
    public class Kosc:INotifyPropertyChanged
    {
        private int _wartosc;
        public int Wartosc 
        {
            get => _wartosc;
            set
            {
                _wartosc = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Wartosc)));
                }
            }
        }

        private bool _czyZaznaczona;
        public bool CzyZaznaczona
        {
            get
            {
                return _czyZaznaczona;
            }
            set
            {
                _czyZaznaczona = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(_czyZaznaczona))); 
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
