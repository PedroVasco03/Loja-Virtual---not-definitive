﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_Virtual
{
    public partial class xioamiRedmi9C : Bunifu.UI.WinForms.BunifuUserControl
    {
        public xioamiRedmi9C()
        {
            InitializeComponent();
        }

        private void lLbl_sobre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Principal frm_Principal = new frm_Principal();
            frm_Principal.Hide();
            frm_informacoes a = new frm_informacoes();
            a.ShowDialog();
        }
    }
}
