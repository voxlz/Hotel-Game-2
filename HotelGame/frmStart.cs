using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelGame
{
    public partial class frmStart : Form
    {
        string hotelName = "";

        public frmStart()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tbxHotelName_TextChanged(object sender, EventArgs e)
        {
            if (this.Text != "")
            {
                hotelName = this.Text;
                btnStart.Enabled = true;
                btnRestart.Enabled = true;
                btnContinue.Enabled = false;
            }
            else
            {
                btnStart.Enabled = false;
                btnRestart.Enabled = false;
                btnContinue.Enabled = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            //this.Hide();
        }
    }
}
