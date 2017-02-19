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
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ////this.Close();
            TTTForm a = new TTTForm();
            a.Show();
            timer1.Enabled = false;
        }

        private void PayingForm_Load(object sender, EventArgs e)
        {

        }

        private void TicketForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
