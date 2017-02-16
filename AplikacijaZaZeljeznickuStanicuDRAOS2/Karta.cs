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
        String ime, prezime;

        private String _ime;

        public String Ime
        {
            get { return _ime; }
            set {
                _ime = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Ime"));
            }
        }

        private String _prezime;

        public String Prezime
        {
            get { return _prezime; }
            set {
                _prezime = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Prezime"));
            }
        }


        public override String ToString()
        {
            return ime + " " + prezime;
        }

        private String _polazakIz;

        public String PolazakIz
        {
            get { return _polazakIz; }
            set { _polazakIz = value; }
        }


        private DateTime _datumPolaska;

        public DateTime DatumPolaska
        {
            get { return _datumPolaska; }
            set { _datumPolaska = value; }
        }

        private DateTime _vrijemePolaska;

        public DateTime VrijemePolaska
        {
            get { return _vrijemePolaska; }
            set { _vrijemePolaska = value; }
        }

        private DateTime _vrijemeDolaska;

        public DateTime VrijemeDolaska
        {
            get { return _vrijemeDolaska; }
            set { _vrijemeDolaska = value; }
        }

        private String _klasa;

        public String Klasa
        {
            get { return _klasa; }
            set { _klasa = value; }
        }

        private String _dolazak;

        public String Dolazak
        {
            get { return _dolazak; }
            set { _dolazak = value; }
        }

        private int _brojPutnik;

        public int BrojPutnika
        {
            get { return _brojPutnik; }
            set { _brojPutnik = value; }
        }

        private String _vrstaKarte;

        public String VrstaKarte
        {
            get { return _vrstaKarte; }
            set { _vrstaKarte = value; }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, e);
        }
    }
}
