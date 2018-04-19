using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DataBinding
{
    public class Persoon : INotifyPropertyChanged 
    {
        private string naamValue;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Naam
        {
            get
            {
                return naamValue;
            }
            set
            {
                naamValue = value;
                RaisePropertyChanged("Naam");
            }
        }

        private void RaisePropertyChanged(String info)
        {
            if( PropertyChanged!= null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }    
        }

        public Persoon(string nNaam,decimal nWedde, DateTime nInDienst)
        {
            Naam = nNaam;
            Wedde = nWedde;
            InDienst = nInDienst;
        }

        private decimal weddeValue;
        public decimal Wedde
        {
            get { return weddeValue; }

            set { weddeValue = value;
                RaisePropertyChanged("Wedde");
            }
        }
        private DateTime inDienstValue;
        public DateTime InDienst
        {
            get { return inDienstValue; }
            set { inDienstValue = value;
                RaisePropertyChanged("InDienst");
            }
        }

    }
}
