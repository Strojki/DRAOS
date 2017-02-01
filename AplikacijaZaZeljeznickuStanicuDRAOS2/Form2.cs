using System;
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
    public partial class Form2 : Form
    {
        Form3 sljedeci;
        public Form2()
        {
            InitializeComponent();
            sljedeci = new Form3();
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
    }
}
