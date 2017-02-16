using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void adjustCulture()
        {
            //groupBox1.Text = rm.GetString("TEST", culture);
        }

        private void bindings()
        {
            textBoxIme.DataBindings.Add("Text", karta, "Ime");
            textBoxPrezime.DataBindings.Add("Text", karta, "Prezime");
        }

        public Korak2Form(ref Karta _karta,ref ResourceManager _rm)
        {
            InitializeComponent();
            sljedeci = new Korak3Form();

            karta = _karta;
            rm = _rm;
            adjustCulture();
            bindings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sljedeci.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Korak2Form_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(karta.ToString());
        }
    }
}
