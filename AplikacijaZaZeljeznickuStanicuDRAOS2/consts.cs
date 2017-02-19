using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaZaZeljeznickuStanicuDRAOS2
{
    public class consts
    {
//        private List<String> _mjesta;

        public static List<String> Mjesta
        {
            get
            {
                var _mjesta = new List<String>() {
                    //"Sarajevo",
                    "Mostar",
                    "Tuzla",
                    "Zenica",
                    "Bihac",
                    "Banja Luka"
                };
                _mjesta.Sort();
                return _mjesta;
            }
            //set { _mjesta = value; }
        }
        public static List<String>Klase
        {
            get
            {
                var _klase = new List<String>()
                {
                    "1",
                    "2",
                    "3"
                };
                return _klase;
            }
        }
        public static List<String>Vrsta
        {
            get
            {
                var _vrste = new List<String>()
                {
                    "Porodicna",
                    "Pojedinacna"
                };
                return _vrste;
            }
        }
        public class Red_Voznje : INotifyPropertyChanged
        {
            public Red_Voznje(string od,string doo,string dolazak,string odlazak)
            {
                Od = od;
                Do = doo;
                this.VrijemeDolaska = dolazak;
                this.VrijemeOdlaska = odlazak;
            }

            public event PropertyChangedEventHandler PropertyChanged;

            public void InvokePropertyChanged(PropertyChangedEventArgs e)
            {
                PropertyChangedEventHandler handler = PropertyChanged;
                if (handler != null) handler(this, e);
            }

            private String _od;

            public String Od
            {
                get { return _od; }
                set { _od = value;
                    InvokePropertyChanged(new PropertyChangedEventArgs("Od"));
                }
            }

            private String _do;

            public String Do
            {
                get { return _do; }
                set { _do = value;
                    InvokePropertyChanged(new PropertyChangedEventArgs("Do"));
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

            private String _vrijemeOdlaska;

            public String VrijemeOdlaska
            {
                get { return _vrijemeOdlaska; }
                set { _vrijemeOdlaska = value;
                    InvokePropertyChanged(new PropertyChangedEventArgs("VrijemeOdlaska"));
                }
            }

        }

        public static List<Red_Voznje>RedVoznje
        {
            get
            {
                var _red = new List<Red_Voznje>()
                {
                    new Red_Voznje("Zenica","Sarajevo","",""),
                    new Red_Voznje("Bihac","Sarajevo","",""),
                    new Red_Voznje("Sarajevo","Zenica","4:40",""),
                    new Red_Voznje("Sarajevo","Zenica","7:40",""),
                    new Red_Voznje("Sarajevo","Zenica","10:40",""),
                    new Red_Voznje("Sarajevo","Zenica","15:40",""),
                    new Red_Voznje("Sarajevo","Banja Luka","12:15",""),
                };
                return _red;
            }
        }
    }
}
