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
    public partial class hp156i3 : Bunifu.UI.WinForms.BunifuUserControl
    {
        public hp156i3()
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
                return lbl_preco.Text;
            }
            set
            {
                lbl_preco.Text = value;
            }
        }
        public static bool fechar = false;
        conexao peg = new conexao();
        MySqlConnection conector = new MySqlConnection("server=localhost; user=root; password=''; database=LOJA_VIRTUAL");
        MySqlCommand cmd;
        int qtd;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string nom = label2.Text;
            int preco = 571000;
            MessageBox.Show(preco.ToString());
            DialogResult confirma = MessageBox.Show("Adicionar ao carrinho o( " + nom.ToString() + " )?", "Confirmação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (confirma == DialogResult.Yes)
            {
                MessageBox.Show(peg.gerarID().ToString());
                try
                {
                    conector.Open();
                    if (peg.verificar(nom,peg.gerarID()))
                    {
                    peg.produtoPreco += preco;
                        preco += preco;
                    cmd = new MySqlCommand("select quantidade from selecionados where produtos ='" + nom.ToString() + "' && idcliente= "+peg.gerarID(), conector);
                    cmd.ExecuteNonQuery();
                    MySqlDataAdapter adapter= new MySqlDataAdapter(cmd);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    qtd = int.Parse(tabela.Rows[0]["quantidade"].ToString());
                    qtd++;
                    string sql = "UPDATE SELECIONADOS SET QUANTIDADE=" + qtd + ", PRECO=" + preco + " where PRODUTOS ='" + nom + "' && idcliente= " + peg.gerarID();
                    MySqlCommand comando = new MySqlCommand(sql, conector);
                    comando.ExecuteNonQuery();

                    }
                    else
                    {
                        peg.produtoPreco = preco;
                        MySqlCommand comando = new MySqlCommand("INSERT INTO SELECIONADOS(PRODUTOS,QUANTIDADE,IDCLIENTE,PRECO) VALUES(@PRODUTOS,@QUANTIDADE,@IDCLIENTE,@PRECO)", conector);
                        comando.Parameters.AddWithValue("@PRODUTOS", nom.ToString());
                        comando.Parameters.AddWithValue("@QUANTIDADE", 1);
                        comando.Parameters.AddWithValue("@IDCLIENTE", peg.gerarID());
                        comando.Parameters.AddWithValue("@PRECO", preco);
                        comando.ExecuteNonQuery();
                    }
                }
                catch(Exception er)
                {
                    MessageBox.Show(er.Message);
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

