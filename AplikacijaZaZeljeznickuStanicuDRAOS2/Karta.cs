using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaZaZeljeznickuStanicuDRAOS2
{
    public class Karta:INotifyPropertyChanged
    {
        public Karta()
        {
            BrojPutnika = "1";
            Klasa = consts.Klase[0];
        }
        //String ime, prezime;

        private String _polazakIz;

        public String PolazakIz
        {
            get { return _polazakIz; }
            set { _polazakIz = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("PolazakIz"));
            }
        }


        private String _datumPolaska;

        public String DatumPolaska
        {
            get { return _datumPolaska; }
            set { _datumPolaska = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("DatumPolaska"));
            }
        }

        private String _vrijemePolaska;

        public String VrijemePolaska
        {
            get { return _vrijemePolaska; }
            set { _vrijemePolaska = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("VrijemePolaska"));
            }
        }

        private String _vrijemeDolaska;

        public String VrijemeDolaska
        {
            get { return _vrijemeDolaska; }
            set { _vrijemeDolaska = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("VrijemeDolaska"));
            }
        }

        private String _klasa;

        public String Klasa
        {
            get { return _klasa; }
            set { _klasa = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Klasa"));
            }
        }

        private String _dolazak;

        public String Dolazak
        {
            get { return _dolazak; }
            set { _dolazak = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Dolazak"));
            }
        }

        private String _brojPutnik;

        public String BrojPutnika
        {
            get { return _brojPutnik; }
            set { _brojPutnik = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("BrojPutnika"));
            }
        }

        private String _vrstaKarte;

        public String VrstaKarte
        {
            get { return _vrstaKarte; }
            set { _vrstaKarte = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("VrstaKarte"));
            }
        }

        public void reset()
        {
            this._brojPutnik = null;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, e);
        }
    }
}
