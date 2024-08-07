using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Loja_Virtual
{
    public partial class frm_Principal : Form
    {
        public frm_Principal() => InitializeComponent();
        conexao pegar = new conexao();
        MySqlConnection conector = new MySqlConnection("server=localhost; user=root; password=''; database=LOJA_VIRTUAL");
        int num = 0;
        int saldoN = 0;
        int saldo = 0;
        string caminhoA = "select * from carteira";
        int numero = 0;
        int saldoConta = 0;
        string nome = "";
        public void listar()
        {
            MySqlDataAdapter adaptador = new MySqlDataAdapter("SELECT Produtos,Quantidade FROM SELECIONADOS WHERE IDCLIENTE= " + pegar.gerarID(), conector);
            DataTable tabela = new DataTable();
            tabela.Clear();
            adaptador.Fill(tabela);
            bunifuDataGridView1.DataSource = tabela;
        }
        private void listarAD()
        {
            MySqlDataAdapter adaptador = new MySqlDataAdapter("select * from carteira", conector);
            DataTable tabela = new DataTable();
            tabela.Clear();
            adaptador.Fill(tabela);
            saldo = int.Parse(tabela.Rows[0]["saldo"].ToString());
            numero = int.Parse(tabela.Rows[0]["NUMCONTA"].ToString());
        }
        private void apresentar(string caminho)
        {
            MySqlDataAdapter adaptador = new MySqlDataAdapter(caminho, conector);
            DataTable tabela = new DataTable();
            tabela.Clear();
            adaptador.Fill(tabela);
            numero = int.Parse(tabela.Rows[0]["numconta"].ToString());
            saldo = int.Parse(tabela.Rows[0]["saldo"].ToString());
            nome = tabela.Rows[0]["NOMEPROPRIETARIO"].ToString();

        }
        private void Btn_inicio_Click(object sender, EventArgs e)
        {
            pages_inicial.SetPage(((Control)sender).Text);
            try
            {
                listar();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conector.Close();
            }

            conector.Open();
            listarAD();
            conector.Close();
            apresentar(caminhoA);
            lbSaldo.Text = saldo.ToString() + "Kzs";
            lbNomep.Text = nome.ToString();
            lbNumConta.Text = numero.ToString();
        }

        

        MySqlCommand cmd;
        int qtd;
        private void btn_eliminardg_Click(object sender, EventArgs e)
        {
            try
            {
                conector.Open();
                DataGridViewRow linha = bunifuDataGridView1.CurrentRow;
                int l = linha.Index;
                string este = bunifuDataGridView1[0, l].Value.ToString();

                cmd = new MySqlCommand("select quantidade from selecionados where produtos= '"+ este +"' && idcliente= " + pegar.gerarID(), conector);
                cmd.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                qtd = int.Parse(tabela.Rows[0]["quantidade"].ToString());
                if (qtd >= 2)
                {
                    DialogResult confirma = MessageBox.Show("Tem certeza que deseja diminuir a quantidade ?", "Diminuir Quantidade", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirma == DialogResult.Yes)
                    {
                        qtd--;
                        string sql = "UPDATE SELECIONADOS SET QUANTIDADE=" + qtd + " where PRODUTOS = '"+ este +"' && idcliente= " +pegar.gerarID();
                        MySqlCommand comando = new MySqlCommand(sql, conector);
                        comando.ExecuteNonQuery();
                    }
                }
                else if (qtd == 1)
                {
                    pegar.excluir(este, pegar.gerarID());
                }
                listar();
            }
            catch 
            {

            }
            finally
            {
                conector.Close();
            }
        }

        private void btn_comprardg_Click(object sender, EventArgs e)
        {
            DialogResult confirma = MessageBox.Show("Tem certeza que deseja comprar produtos?", "Efetuar Compras", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirma == DialogResult.Yes)
            {
                string data = DateTime.Now.ToString();
            }

        }



        private void lb_alterar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_nome.Enabled = true;
            txt_nome.ReadOnly = false;
            txt_password.Enabled = true;
            txt_password.ReadOnly = false;
            txt_telefone.Enabled = true;
            txt_telefone.ReadOnly = false;
            cmb_provincia.Enabled = true;
            data_nascimento.Enabled = true;
            rd_feminino.Enabled = true;
            rd_masculino.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo Eliminar esta conta?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pegar.eliminar(conexao.pegar);
                MessageBox.Show("Conta Eliminada com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Login cha = new Login();
                cha.Show();
            }
        }


        public int escolherProvincia(string provincia)
        {
            int cont = 0;
            switch (provincia)
            {
                case "Luanda":
                    cont = 1;
                    break;
                case "Benguela":
                    cont = 2;
                    break;
                case "Uíge":
                    cont = 3;
                    break;
                case "Malange":
                    cont = 4;
                    break;
                case "Moxico":
                    cont = 5;
                    break;

                case "Lunda Norte":
                    cont = 6;
                    break;
                case "Lunda Sul":
                    cont = 7;
                    break;
                case "Bié":
                    cont = 8;
                    break;
                case "Zaire":
                    cont = 9;
                    break;
                case "Namibe":
                    cont = 10;
                    break;
                case "Bengo":
                    cont = 11;
                    break;
                case "Kwanza Sul":
                    cont = 12;
                    break;
                case "Kwanza Norte":
                    cont = 13;
                    break;
                case "Cabinda":
                    cont = 14;
                    break;
                case "Huambo":
                    cont = 15;
                    break;
                case "Huíla":
                    cont = 16;
                    break;
                case "Cunene":
                    cont = 17;
                    break;
                case "Cuando Cubango":
                    cont = 18;
                    break;


            }
            return cont;
        }
        private char sexo()
        {
            char sexo;
            if (rd_masculino.Checked)
            {
                sexo = 'M';
            }
            else
            {
                sexo = 'F';
            }
            return sexo;
        }
        private bool date(string ano)
        {
            bool checar;
            DateTime data = DateTime.Now;
            int idade = data.Year - int.Parse(ano);
            if (idade >= 18)
            {
                checar = true;
            }
            else
            {
                MessageBox.Show("A idade é inferior a 18 anos", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checar = false;
            }
            return checar;
        }
        private bool tele(int tel)
        {
            bool checar;
            string telefone = tel.ToString();
            if (telefone.Length == 9)
            {
                checar = true;
            }
            else
            {
                MessageBox.Show("Numero de telefone deve conter 9 dígitos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checar = false;
            }
            return checar;
        }
        private bool verSenha(string senha)
        {
            bool checar;
            if (senha.Trim().Length > 3)
            {
                checar = true;
            }
            else
            {
                MessageBox.Show("Digite uma senha mais forte");
                checar = false;
            }
            return checar;
        }
        bool name = true;
        bool pass = true;
        bool tel = true;
        private void btnguardar_Click(object sender, EventArgs e)
        {

            if (txt_nome.Text != "" && txt_telefone.Text != "" && txt_password.Text != "" && cmb_provincia.Text != "" && data_nascimento.Value.ToString() != "")
            {
                if (conexao.pegar != txt_nome.Text)
                {
                    name = !pegar.existeNome(txt_nome.Text);
                }
                if (conexao.pegartelefone != int.Parse(txt_telefone.Text))
                {
                    tel = !pegar.existeTelefone(int.Parse(txt_telefone.Text));
                }
                if (conexao.pegarsenha != txt_password.Text)
                {
                    pass = !pegar.existeSenha(txt_password.Text);
                }


                if (name && pass && tel && date(data_nascimento.Value.Year.ToString()) && tele(int.Parse(txt_telefone.Text)) && verSenha(txt_password.Text))
                {
                    string data = data_nascimento.Value.Year.ToString() + "-" + data_nascimento.Value.Month.ToString() + "-" + data_nascimento.Value.Day.ToString();
                    pegar.atualizar(txt_nome.Text, data, txt_password.Text, sexo(), int.Parse(txt_telefone.Text), escolherProvincia(cmb_provincia.Text));
                    MessageBox.Show("Dados salvos com sucesso!\nSerá fechado para que as alterações sejam efectuados", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Login cha = new Login();
                    cha.Show();
                }


            }


        }

        private void pages_inicial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
            pegar.status(conexao.pegar);
            txt_nome.Text = pegar.nome;
            txt_telefone.Text = pegar.telefone.ToString();
            txt_password.Text = pegar.senha;
            cmb_provincia.Text = pegar.provincia;
            data_nascimento.Value = DateTime.Parse(pegar.data);
            if (pegar.sexo == 'F')
            {
                rd_feminino.Checked = true;
                rd_masculino.Enabled = false;
                rd_masculino.Checked = false;

            }
            if (pegar.sexo == 'M')
            {
                rd_masculino.Checked = true;
                rd_feminino.Enabled = false;
                rd_feminino.Checked = false;

            }
            txt_nome.Enabled = false;
            txt_nome.ReadOnly = false;
            txt_password.Enabled = false;
            txt_password.ReadOnly = false;
            txt_telefone.Enabled = false;
            txt_telefone.ReadOnly = false;
            cmb_provincia.Enabled = false;
            data_nascimento.Enabled = false;
            apresentar(caminhoA);
            lbSaldo.Text = saldo.ToString() + "Kzs";
            lbNomep.Text = nome.ToString();
            txt_numConta.Text = numero.ToString();
            txtNumCont.Text = numero.ToString();
        }
        private void btnAddFund_Click(object sender, EventArgs e)
        {
            pages_inicial.SetPage(((Control)sender).Text);
            btn_carteira.Focus();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            pages_inicial.SetPage("CARTEIRA");
            btn_carteira.Focus();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (txt_senhaDeposito.Text==pegar.senha){ 
            if ((int.Parse(txtvalor.Text) > 0) && (numero == int.Parse(txtNumCont.Text)))
            {
                try
                {
                    conector.Open();
                    listarAD();
                    saldoN = saldo + int.Parse(txtvalor.Text);
                    MySqlCommand cmd = new MySqlCommand("update carteira set saldo=@saldo where numconta=@numconta", conector);
                    cmd.Parameters.Add("@saldo", MySqlDbType.Int32).Value = saldoN;
                    cmd.Parameters.Add("@numconta", MySqlDbType.Int32).Value = int.Parse(txtNumCont.Text);
                    cmd.ExecuteNonQuery();
                    apresentar(caminhoA);
                    lbSaldo.Text = saldo.ToString() + "Kzs";
                    MessageBox.Show("Valores adicionados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pages_inicial.SetPage("CARTEIRA");
                        apresentar(caminhoA);
                        lbSaldo.Text = saldo.ToString() + "Kzs";
                        lbNomep.Text = nome.ToString();
                        lbNumConta.Text = numero.ToString();
                        btn_carteira.Focus();
                        listarAD();
                        this.Show();
                        txt_senhaDeposito.Text = "";
                        txtvalor.Text = "";
                    }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    conector.Close();
                }
            }
            else
            {
                MessageBox.Show("Valor ou número de conta inválidos. Tente novamente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            else
            {
                MessageBox.Show("Senha inválida. Tente novamente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void ckb_verSenha_enventoParaSaberestadodaCKB(object sender, EventArgs e)
        {
            if (ckb_verSenha.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
               txt_password.UseSystemPasswordChar = true; 
            }
        }

        private void frm_Principal_Activated(object sender, EventArgs e)
        {
            if (hp156i3.fechar)
                this.Close();
        }

        private void lLbl_sobre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frm_informacoes chama = new frm_informacoes();
            chama.ShowDialog();
        }
    }
    }

