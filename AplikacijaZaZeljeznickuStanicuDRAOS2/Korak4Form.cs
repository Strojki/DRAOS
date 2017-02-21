using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaZaZeljeznickuStanicuDRAOS2
{
    public partial class Korak4Form : Form
    {
        Karta karta;
        ResourceManager rm;
        CultureInfo culture;
        String helpText;

        public Korak4Form(ref Karta _karta, ref ResourceManager _rm, ref CultureInfo _cul)
        {
            karta = _karta;
            rm = _rm;
            culture = _cul;

            InitializeComponent();


            adjustCulture();
            bindings();
            labelM.Text = "Sarajevo " + DateTime.Now.ToString();
        }

        private void adjustCulture()
        {
            culture = consts.Culture;
            helpText = rm.GetString("helpSadrzajKorak4", culture);
            //button1.Text = "Plati kartu";
            //throw new NotImplementedException();
            button4.Text = rm.GetString("Korak1", culture);
            button5.Text = rm.GetString("Korak2", culture);
            button6.Text = rm.GetString("Korak3", culture);
            button7.Text = rm.GetString("Korak4", culture);
            button1.Text = rm.GetString("Naprijed", culture);
            button2.Text = rm.GetString("Ponisti", culture);
        }

        private void bindings()
        {
            //String rez = String.Format("Ime {0} Prezime {1}"+@"\par", karta.Ime, karta.Prezime);
            //richTextBox1.Rtf = @"{\rtf1\pc "+rez;
            //richTextBox1.Rtf = @"{\rtf1\pc \b "+karta.Ime+
            //    @"\b0 \par ";
            //richTextBox1.AppendText();
            //richTextBox1.AppendText(String.Format("Prezime {0} \n", karta.Prezime));
            //richTextBox1.AppendText(String.Format("Vrsta karte {0} \n", karta.VrstaKarte));
            //karta.VrijemePolaska;karta.VrijemeDolaska;karta.Prezime;karta.PolazakIz;karta.Klasa;
            //karta.Ime;karta.Dolazak;karta.DatumPolaska;karta.BrojPutnika;
            //throw new NotImplementedException();
        }

        private void Korak4Form_Load(object sender, EventArgs e)
        {
            //karta
            adjustCulture();
            Random rnd = new Random();
            richTextBox1.Rtf = consts.KartaText(karta.BrojPutnika, karta.Klasa, karta.VrijemePolaska,karta.VrijemeDolaska,rnd.Next(1111,9999).ToString(),"123 KM");//,karta.Klasa,"od vremena","do vremena","serialnbrt","cijena")+"}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //richTextBox1.AppendText("\nyooo");
            //richTextBox1.Rtf = @"{\rtf1\pc \b 02/11/2010 - 05:15 PM - Adam:\b0 Another test notes added on 2nd November \par \b 02/11/2010 - 05:14 PM - Z_kas:\b0 Test Notes. STAGE CHANGED TO: N Enq - Send Quote\par \b 02/11/2010 - 05:12 PM - user32:\b0 Another test notes added on 2nd November";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TicketForm a = new TicketForm();
            a.Show();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            labelM.Text = "Sarajevo " + DateTime.Now.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TicketForm a = new TicketForm();
            a.Show();
            this.Hide();
            this.Close();
            MessageBox.Show("Transaction complete");
            StartForm b = new StartForm();
            b.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            this.Close();
            this.Hide();
            Korak3Form f = new Korak3Form(ref karta, ref rm,ref culture);
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(helpText);
        }

        private void Korak4Form_Shown(object sender, EventArgs e)
        {
            adjustCulture();
        }
    }
}
