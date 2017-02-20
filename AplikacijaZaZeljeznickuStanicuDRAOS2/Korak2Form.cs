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
    public partial class Korak2Form : Form
    {
        Korak3Form sljedeci;
        Karta karta;
        ResourceManager rm;
        consts _const;
        String helpText;
        private CultureInfo culture;

        private void adjustCulture()
        {
            culture = consts.Culture;
            helpText = rm.GetString("helpSadrzajKorak2", culture);
            //groupBox1.Text = rm.GetString("TEST", culture);
        }

        private void bindings()
        {
            //textBoxIme.DataBindings.Add("Text", karta, "Ime");
            //textBoxPrezime.DataBindings.Add("Text", karta, "Prezime");
            //karta.PolazakIz
            comboBoxPolazakIz.DataBindings.Add("Text", karta, "PolazakIz");
            //karta.Dolazak;
            comboBoxDolazak.DataBindings.Add("Text", karta, "Dolazak");
            //karta.VrstaKarte;
            comboBoxVrstaKarte.DataBindings.Add("Text", karta, "VrstaKarte");
            //karta.BrojPutnika;
            comboBox1.DataBindings.Add("Text", karta, "BrojPutnika");
        }

        public Korak2Form(ref Karta _karta,ref ResourceManager _rm,ref CultureInfo _cul)
        {
            InitializeComponent();
            sljedeci = new Korak3Form(ref _karta,ref _rm,ref culture);

            karta = _karta;
            rm = _rm;
            culture = _cul;
            _const = new consts();
            comboBoxPolazakIz.Items.AddRange(consts.Mjesta.Cast<Object>().ToArray());
            comboBoxDolazak.Items.AddRange(consts.Mjesta.Cast<Object>().ToArray());
            comboBoxVrstaKarte.Items.AddRange(consts.Vrsta.Cast<Object>().ToArray());

            adjustCulture();
            bindings();

            //consts.Forme.Push(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sljedeci.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            StartForm f = new StartForm();
            f.ShowDialog();
        }

        private void Korak2Form_Load(object sender, EventArgs e)
        {
            adjustCulture();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(helpText);
        }

        private void kartaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Korak2Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //consts.Forme.Pop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelM.Text = "Sarajevo " + DateTime.Now.ToString();
        }

        private void Korak2Form_Shown(object sender, EventArgs e)
        {
            adjustCulture();
        }
    }
}
