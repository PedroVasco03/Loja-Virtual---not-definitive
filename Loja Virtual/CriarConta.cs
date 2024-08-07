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
    public partial class CriarConta : Form
    {
        public CriarConta()
        {
            InitializeComponent();
        }

        conexao chamar = new conexao();

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
            int idade = data.Year -int.Parse(ano);
            if(idade >= 18)
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
            if(senha.Trim().Length > 3)
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
        private void btn_entrar_Click(object sender, EventArgs e)
        {
            try {
                if(txt_nome.Text !="" && txt_telefone.Text != "" && txt_password.Text != "" && data_nascimento.Value.ToString()!="" && cmb_provincia.Text !="" && txt_capitalInicial.Text!="")
                {
                    bool name = chamar.existeNome(txt_nome.Text);
                    bool pass = chamar.existeSenha(txt_password.Text);

                    bool tel = chamar.existeTelefone(int.Parse(txt_telefone.Text));
                    if (!name && !pass && !tel && date(data_nascimento.Value.Year.ToString()) && tele(int.Parse(txt_telefone.Text))&&verSenha(txt_password.Text))
                    {

                        string data = data_nascimento.Value.Year.ToString() + "-" + data_nascimento.Value.Month.ToString() + "-" + data_nascimento.Value.Day.ToString();
                        chamar.inserir(txt_nome.Text, data, int.Parse(txt_telefone.Text), sexo(), txt_password.Text,escolherProvincia(cmb_provincia.Text),txt_numConta.Text,int.Parse(txt_capitalInicial.Text));
                        MessageBox.Show("Dados Salvos com sucesso","Verificação",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Hide();
                        Login l = new Login();
                        l.Show();
                    }

                }
                if (txt_nome.Text == "" && txt_telefone.Text == "" && txt_password.Text == "" && cmb_provincia.Text =="")
                {
                    MessageBox.Show("Preencha todos os campos devidamente","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            if(!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ch = new Login();
            ch.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CriarConta_Load(object sender, EventArgs e)
        {
            txt_numConta.Text = chamar.GerarNumeroConta();
        }
    }
}
