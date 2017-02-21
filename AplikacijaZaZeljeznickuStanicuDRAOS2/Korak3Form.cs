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
    public partial class Korak3Form : Form
    {
        Karta karta;
        ResourceManager rm;
        CultureInfo culture;
        String helpText;

        public Korak3Form(ref Karta _karta, ref ResourceManager _rm, ref CultureInfo _cul)
        {
            InitializeComponent();
            karta = _karta;
            rm = _rm;
            culture = _cul;
            adjustCulture();
            bindings();
            labelM.Text = "Sarajevo " + DateTime.Now.ToString();
        }

        private void bindings()
        {
            comboBoxKlasa.DataBindings.Add("text", karta, "Klasa");
            dateTimePicker1.DataBindings.Add("text", karta, "DatumPolaska");
            comboBoxVrijemePolaska.DataBindings.Add("text", karta, "VrijemePolaska");
            comboBoxVrijemeDolaska.DataBindings.Add("text", karta, "VrijemeDolaska");
            //throw new NotImplementedException();
        }

        private void adjustCulture()
        {
            culture = consts.Culture;
            helpText = rm.GetString("helpSadrzajKorak3", culture);
            //throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Korak2Form f = new Korak2Form(ref karta, ref rm, ref culture);
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxVrijemePolaska.SelectedItem == null)
                MessageBox.Show("Niste unijeli vrijeme polaska!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (comboBoxVrijemeDolaska.SelectedItem == null)
                MessageBox.Show("Niste unijeli vrijeme dolaska!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (comboBoxKlasa.SelectedItem == null)
                MessageBox.Show("Niste unijeli klasu!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (comboBoxVrijemePolaska.SelectedItem == comboBoxVrijemeDolaska.SelectedItem)
                MessageBox.Show("Vrijeme polaska i dolaska je isto!", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Korak4Form f = new Korak4Form(ref karta, ref rm, ref culture);
                this.Hide();
                f.ShowDialog();
            }  
        }

        private void Korak3Form_Load(object sender, EventArgs e)
        {
            adjustCulture();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelM.Text = "Sarajevo " + DateTime.Now.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(helpText);
        }

        private void Korak3Form_Shown(object sender, EventArgs e)
        {
            adjustCulture();
        }
    }
}
