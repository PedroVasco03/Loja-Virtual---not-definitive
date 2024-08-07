using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_Virtual
{
    public partial class MessageConfirm : Form
    {
        public MessageConfirm()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Principal ch = new frm_Principal();
            ch.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval ==5000)
            {
                timer1.Enabled = false;
                this.Close();
                frm_Principal ch = new frm_Principal();
                ch.Show();
            }
        }
    }
}
