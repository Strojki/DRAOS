using System;
using System.Resources;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaZaZeljeznickuStanicuDRAOS2
{
    public partial class StartForm : Form
    {
        private Korak2Form nextForm;
        private CultureInfo culture;
        private ResourceManager rm;
        private Karta karta;
        private String helpText;

        private void adjustCulture()
        {
            culture = consts.Culture;
            groupBox1.Text = rm.GetString("TEST", culture);
            helpText = rm.GetString("helpSadrzajKorak1", culture);
        }

        public StartForm()
        {
            culture = CultureInfo.CurrentCulture;
            rm = new ResourceManager("AplikacijaZaZeljeznickuStanicuDRAOS2.lang", typeof(StartForm).Assembly);
            karta = new Karta();
            //karta.Ime = "Ime";
            //richTextBox1.Rtf = @"";
            InitializeComponent();
            setLang("ba");
            BindingSource bs = new BindingSource();
            bs.DataSource = consts.RedVoznje;
            dataGridView1.DataSource = bs;
            this.Name = "Start";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nextForm = new Korak2Form(ref karta,ref rm,ref culture);
            labelM.Text = "Sarajevo " + DateTime.Now.ToString();
            //this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(karta.ToString());
            Korak4Form f = new Korak4Form(ref karta, ref rm,ref culture);
            f.ShowDialog();
        }

        private void setLang(string lang)
        {
            culture = CultureInfo.CreateSpecificCulture(lang);
            consts.Culture = culture;
            adjustCulture();
            //groupBox1.Text = rm.GetString("TEST", culture);
        }

        private void setLangEn(object sender, EventArgs e)
        {
            setLang("en");
        }

        private void setLangDe(object sender, EventArgs e)
        {
            setLang("de");
        }

        private void setLangTr(object sender, EventArgs e)
        {
            setLang("tr");
        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            karta.reset();
            nextForm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelM.Text = "Sarajevo " + DateTime.Now.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(helpText);
        }

        private void StartForm_Shown(object sender, EventArgs e)
        {
            adjustCulture();
        }
    }
}
