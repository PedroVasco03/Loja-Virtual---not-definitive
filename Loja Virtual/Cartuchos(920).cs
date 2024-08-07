using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Loja_Virtual
{
    public partial class hp450i7W11 : Bunifu.UI.WinForms.BunifuUserControl
    {
        public hp450i7W11()
        {
            InitializeComponent();
        }
        public Image ItemImage
        {
            get
            {
                return pictureBox2.Image;
            }
            set
            {
                pictureBox2.Image = value;
            }
        }
        public string itemLabel
        {
            get
            {
                return label2.Text;
            }
            set
            {
                label2.Text = value;
            }
        }
        public string itemPrice
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
        MySqlConnection conector = new MySqlConnection("server=localhost; user=root; password=''; database=LOJA_VIRTUAL");
        MySqlCommand cmd;
        int qtd;
        public void pictureBox2_Click(object sender, EventArgs e)
        {
            conexao peg = new conexao();
            string nom = label2.Text;
            DialogResult confirma = MessageBox.Show("Adicionar ao carrinho o( " + nom + " )?", "Confirmação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (confirma == DialogResult.Yes)
            {
                try
                {
                    conector.Open();

                    MySqlCommand comando = new MySqlCommand("INSERT INTO SELECIONADOS(PRODUTOS,QUANTIDADE,IDCLIENTE) VALUES(@PRODUTOS,@QUANTIDADE,@IDCLIENTE)", conector);
                    comando.Parameters.AddWithValue("@PRODUTOS", nom.ToString());
                    comando.Parameters.AddWithValue("@QUANTIDADE", 1);
                    comando.Parameters.AddWithValue("@IDCLIENTE", peg.gerarID());
                    comando.ExecuteNonQuery();
                }
                catch
                {
                    cmd = new MySqlCommand("select quantidade from selecionados where produtos ='" + nom.ToString() + "' ", conector);
                    cmd.ExecuteNonQuery();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    qtd = int.Parse(tabela.Rows[0]["quantidade"].ToString());
                    qtd++;
                    string sql = "UPDATE SELECIONADOS SET QUANTIDADE=" + qtd + " where PRODUTOS ='" + nom + "'";
                    MySqlCommand comando = new MySqlCommand(sql, conector);
                    comando.ExecuteNonQuery();
                }
                finally
                {
                    conector.Close();
                }
            }
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
