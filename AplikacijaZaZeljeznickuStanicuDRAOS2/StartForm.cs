﻿using System;
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

        private void adjustCulture()
        {
            groupBox1.Text = rm.GetString("TEST", culture);
        }

        public StartForm()
        {
            culture = CultureInfo.CurrentCulture;
            rm = new ResourceManager("AplikacijaZaZeljeznickuStanicuDRAOS2.lang", typeof(StartForm).Assembly);
            karta = new Karta();
            karta.Ime = "Ime";

            InitializeComponent();
            adjustCulture();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nextForm = new Korak2Form(ref karta,ref rm);
            //this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            karta = new Karta();
            nextForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(karta.ToString());
        }

        private void setLang(string lang)
        {
            culture = CultureInfo.CreateSpecificCulture(lang);
            groupBox1.Text = rm.GetString("TEST", culture);
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

    }
}
