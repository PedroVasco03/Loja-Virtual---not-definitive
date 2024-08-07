using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Loja_Virtual
{
    class conexao
    {
        MySqlConnection conector = new MySqlConnection("server=localhost; user=root; password=''; database=LOJA_VIRTUAL");
        private MySqlConnection conetar = new MySqlConnection("server='localhost';user='root';password='';database='loja_virtual'");
        public MySqlCommand cmd;
        public MySqlCommand cmd2;
        public MySqlDataAdapter adaptador;
        DataTable tabela;
        public static string nomeProduto;
        public static string preco;

        public static string pegar;
        public static int pegartelefone;
        public static string pegarsenha;
        public static int pegarid;
        public int _id;
        public string nome;
        public int telefone;
        public char sexo;
        public string data;
        public string senha;
        public int produtoPreco =0;
        public string provincia;
        public int gerarID()
        {
            conector.Open();
            cmd = new MySqlCommand("select id from cliente where nome ='" + pegar + "' ", conector);
            cmd.ExecuteNonQuery();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            int seuID = int.Parse(tabela.Rows[0]["id"].ToString());
            conector.Close();
            return seuID;
        }
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        public string[] provincias =
            {
                "Luanda",
                "Benguela",
                "Uíge",
                "Malange",
                "Moxico",
                "Lunda Norte",
                "Lunda Sul",
                "Bié",
                "Zaire",
                "Namibe",
                "Bengo",
                "Kwanza Sul",
                "Kwanza Norte",
                "Cabinda",
                "Huambo",
                "Huíla",
                "Cunene",
                "Cuando Cubango"
        };
        bool tel;
        bool name;
        bool pass;
        public bool existeNome(string nome)
        {
            try
            {
                conetar.Open();
                cmd = new MySqlCommand("select nome from cliente where nome = @nome", conetar);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.ExecuteNonQuery();
                adaptador = new MySqlDataAdapter(cmd);
                tabela = new DataTable();
                adaptador.Fill(tabela);
                this.nome = tabela.Rows[0]["nome"].ToString();
                MessageBox.Show("já existe este nome", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                name = true;
            }
            catch
            {

                name = false;
            }
            finally
            {
                conetar.Close();
            }
            return name;
        }
        MySqlDataAdapter adapter;
        DataTable table;
        public bool verificar(string produto, int id)
        {
            var op = false;
            try
            {

                conetar.Open();
                cmd = new MySqlCommand("select * from selecionados where idcliente = @idcliente", conetar);
                cmd.Parameters.AddWithValue("@idcliente", id);
                cmd.ExecuteNonQuery();
                adapter = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adapter.Fill(table);
                for (int c = 0; c < table.Rows.Count; c++)
                {

                    if (table.Rows[c]["produtos"].ToString().Contains(produto))
                    {
                        produto = table.Rows[c]["produtos"].ToString();
                        op = true;
                        break;
                    }
                    else
                    {
                        op = false;
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conetar.Close();
            }return op;
        }
            public void verificarNome(string nome)
            {
            try
            {
                conetar.Open();
                cmd = new MySqlCommand("select * from cliente where nome = @nome", conetar);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.ExecuteNonQuery();
                adaptador = new MySqlDataAdapter(cmd);
                tabela = new DataTable();
                adaptador.Fill(tabela);
                this.nome = tabela.Rows[0]["nome"].ToString();
                this.telefone = int.Parse(tabela.Rows[0]["telefone"].ToString());
                this.senha = tabela.Rows[0]["senha"].ToString();

            }
            catch
            {

                MessageBox.Show("Este Usuário não existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conetar.Close();
            }

            }
        public void verificarSenha(string var)
        {
            try
            {
                conetar.Open();
                cmd = new MySqlCommand("select senha from cliente where nome = @nome", conetar);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.ExecuteNonQuery();
                adaptador = new MySqlDataAdapter(cmd);
                tabela = new DataTable();
                adaptador.Fill(tabela);
                this.senha = tabela.Rows[0]["senha"].ToString();


            }
            catch
            {



            }
            finally
            {
                conetar.Close();
            }


        }
        public bool existeTelefone(int telefone)
        {

            try
            {
                conetar.Open();
                cmd = new MySqlCommand("select telefone from cliente where telefone = @telefone", conetar);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.ExecuteNonQuery();
                adaptador = new MySqlDataAdapter(cmd);
                tabela = new DataTable();
                adaptador.Fill(tabela);
                this.telefone = int.Parse(tabela.Rows[0]["telefone"].ToString());
                MessageBox.Show("já existe este número de telefone", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tel = true;


            }
            catch
            {

                tel = false;
            }
            finally
            {

                conetar.Close();
            }


            return tel;
        }
        public bool existeSenha(string senha)
        {

            try
            {
                conetar.Open();
                cmd = new MySqlCommand("select senha from cliente where senha = @senha", conetar);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.ExecuteNonQuery();
                adaptador = new MySqlDataAdapter(cmd);
                tabela = new DataTable();
                adaptador.Fill(tabela);
                this.senha = tabela.Rows[0]["senha"].ToString();
                MessageBox.Show("já existe esta senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pass = true;
            }
            catch
            {

                pass = false;
            }
            finally
            {
                conetar.Close();
            }



            return pass;
        }
        
        public void inserir(string nome, string nascimento, int telefone, char sexo, string senha, int provincia, string numeroConta, int saldo)
        {
            try
            {
                conetar.Open();
                cmd = new MySqlCommand("insert into cliente(nome,data_nascimento,telefone,sexo,senha,id_provincia,NUMCONTA) values(@nome,@data_nascimento,@telefone,@sexo,@senha,@id_provincia,@numeroConta)", conetar);
                cmd2 = new MySqlCommand("insert into carteira(NUMCONTA,NOMEPROPRIETARIO,SALDO) values(@numeroConta,@nome,@saldo)", conetar);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd2.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@data_nascimento", nascimento);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@id_provincia", provincia);
                cmd.Parameters.AddWithValue("@numeroConta", numeroConta);
                cmd2.Parameters.AddWithValue("@numeroConta", numeroConta);
                cmd2.Parameters.AddWithValue("@saldo", saldo);
                cmd2.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conetar.Close();
            }
        }
        public void status(string nome)
        {
            try
            {
                conetar.Open();
                cmd = new MySqlCommand("select * from cliente where nome = @nome", conetar);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.ExecuteNonQuery();
                adaptador = new MySqlDataAdapter(cmd);
                tabela = new DataTable();
                adaptador.Fill(tabela);
                this.id = int.Parse(tabela.Rows[0]["id"].ToString());
                conetar.Close();
                conetar.Open();
                cmd = new MySqlCommand("select * from cliente where id = @id", conetar);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                adaptador = new MySqlDataAdapter(cmd);
                tabela = new DataTable();
                adaptador.Fill(tabela);
                this.nome = tabela.Rows[0]["nome"].ToString();
                this.telefone = int.Parse(tabela.Rows[0]["telefone"].ToString());
                this.senha = tabela.Rows[0]["senha"].ToString();
                this.sexo = char.Parse(tabela.Rows[0]["sexo"].ToString());
                this.provincia = provincias[int.Parse(tabela.Rows[0]["id_provincia"].ToString())];
                this.data = tabela.Rows[0]["data_nascimento"].ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                conetar.Close();
            }
        }
        public void eliminar(string nome)
        {
            try
            {
                conetar.Open();
                cmd = new MySqlCommand("delete from cliente where nome = @nome", conetar);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                conetar.Close();
            }
        }
        public void atualizar(string nome, string date, string senha, char sexo, int telefone, int provincia)
        {
            try
            {
                conetar.Open();
                cmd = new MySqlCommand("update cliente set nome = @nome,data_nascimento = data_nascimento,telefone = @telefone,senha = @senha,sexo = @sexo, id_provincia = @id_provincia where nome = @nome", conetar);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@data_nascimento", date);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@id_provincia", provincia);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conetar.Close();
            }
        }


        public void excluir(string nom,int seuid)
        {
            try
            {
                DialogResult confirma = MessageBox.Show("Tem certeza que deseja excluir este produto?", "Eliminar Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirma == DialogResult.Yes)
                {

                    conector.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conector;
                    string este = nom;
                    //bunifuDataGridView1.Rows.RemoveAt(l);
                    cmd.CommandText = "DELETE FROM selecionados where produtos='" + este + "' && idcliente= "+seuid;
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }
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
        public bool VerificarNumeroConta( string numeroConta, bool verificar = true)
        {

            //verificar se o número de conta já existe
            var validar = false;
            try
            {

                conetar.Open();
                cmd = new MySqlCommand("select * from carteira", conetar);
                //cmd.Parameters.AddWithValue("@idcliente", id);
                cmd.ExecuteNonQuery();
                adapter = new MySqlDataAdapter(cmd);
                table = new DataTable();
                adapter.Fill(table);
                for (int c = 0; c < table.Rows.Count; c++)
                {

                    if (table.Rows[c]["NUMCONTA"].ToString().Contains(numeroConta))
                    {
                        numeroConta = table.Rows[c]["numconta"].ToString();
                        validar = true;
                        break;
                    }
                    else
                    {
                        validar = false;
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conetar.Close();
            }
            return validar;
        }
        public string GerarNumeroConta()
        {
        comeco:
            string numeroConta;
            //gerar número de conta
            Random rand = new Random(DateTime.Now.Millisecond);
            numeroConta = rand.Next(100000000, 999999999).ToString();
            numeroConta += rand.Next(1000, 9999).ToString();


            if (VerificarNumeroConta(numeroConta, false))
                goto comeco;

            return numeroConta;
        }

    }
}
 