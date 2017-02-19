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
    public partial class TTTForm : Form
    {
        public TTTForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            closeAll();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void closeAll()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Start")
                    Application.OpenForms[i].Close();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            closeAll();
        }
    }
}
