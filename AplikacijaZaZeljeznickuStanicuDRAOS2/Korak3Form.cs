﻿using System;
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
    public partial class Korak3Form : Form
    {
        Karta karta;
        ResourceManager rm;

        public Korak3Form(ref Karta _karta, ref ResourceManager _rm)
        {
            InitializeComponent();
            karta = _karta;
            rm = _rm;
            adjustCulture();
            bindings();
            labelM.Text = "Sarajevo " + DateTime.Now.ToString();
        }

        private void bindings()
        {
            //throw new NotImplementedException();
        }

        private void adjustCulture()
        {
            //throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Korak4Form f = new Korak4Form(ref karta, ref rm);
            f.ShowDialog();
        }

        private void Korak3Form_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelM.Text = "Sarajevo " + DateTime.Now.ToString();
        }
    }
}
