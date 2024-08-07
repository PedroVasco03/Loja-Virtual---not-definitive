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
    public partial class frm_Carregamento : Form
    {
        public frm_Carregamento()
        {
            InitializeComponent();
            pictureBoxTablets.Visible = false;

        }
        int counter = 0;
        int len = 0;
        string text;
        int count = 0;

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelLoading.Width += 3;
             
            if(panelLoading.Width >= 600)
            {
                timer1.Stop();
                Login chama = new Login();
                
                chama.Show();
                this.Hide();
            }
            
        }
        int j = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            j++;

            switch (j)
            {
                case  3: pictureBoxCelular.Visible = false; break;
                case  6: pictureBoxRelogio.Visible = false; break;
                case  9: pictureBoxTablets.Visible = true;  break;
                case 12: pictureBoxTablets.Visible = false; break;
                case 13: pictureBoxCelular.Visible = true;  break;
              
                
            }
            
        }


        private void timer3_Tick(object sender, EventArgs e)
        {
            labelMensagem.Text = text.Substring(0, counter);
            ++counter;
            if(counter > len)
            {
                labelMensagem.Show();
                timer3.Stop();
                
            }
            count++;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            text = labelMensagem.Text;
            len = text.Length;
            labelMensagem.Text = "";
            timer3.Start();
        }
    }
}
