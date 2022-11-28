using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Trabalho.katia
{
    public partial class Form1 : Form
    {
        Conexao conectar = new Conexao();
        public Form1()
        {
            InitializeComponent();
            btnalterar.Enabled = false;
            button3.Enabled = false;
        }
        public void Limpar()
        {
            txtid.Text = null;
            txtcnpj.Text = null ;
            txtrazaosocial.Text = null;
            txtendereco.Text = null;
            txtemail.Text = null;
            txtnomefantasia.Text = null;
            txttelefone.Text = null;
            txtinscricaoestadual.Text = null;
        }

        #region baotao tela de cadastro
        private void btncadastro_Click(object sender, EventArgs e)
        {
            ProdutoForm2 produtoForm = new ProdutoForm2();
            produtoForm.Show();
        }
        #endregion

        #region botao inserir
        private void btninserir_Click(object sender, EventArgs e)
        {
            string parametros = $"insert into fornecedor values('{txtid.Text}','{txtcnpj.Text}','{txtrazaosocial.Text}','{txtendereco.Text}','{txtemail.Text}','{txtnomefantasia.Text}','{txttelefone.Text}','{txtinscricaoestadual.Text}')";
            conectar.Comm(parametros);
            MessageBox.Show("Fornecedor cadastrado com sucesso");
            Limpar();
        }
        #endregion

        #region Botao excluir
        private void button3_Click(object sender, EventArgs e)//btnExcluir
        {
            button3.Enabled = false;
            string parametros = $"delete from fornecedor where idfornecedor = '{txtid.Text}'";
            conectar.Comm(parametros);
            MessageBox.Show("Fornecedor excluido com sucesso");
            Limpar();
        }
        #endregion

        #region Botao pesquisar
        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            btnalterar.Enabled = true;
            MySqlConnection abrir = new MySqlConnection("server=localhost;User Id=root;database=bd_cadastro;password=C964625");
            try
            {
                string parametros = $"select * from fornecedor where idfornecedor = '{txtid.Text}'";
                abrir.Open();

                MySqlCommand cmd = new MySqlCommand(parametros, abrir);
                MySqlDataReader read;

                read = cmd.ExecuteReader();

                while (read.Read())
                {
                    txtcnpj.Text = Convert.ToString(read["Cnpj"]);
                    txtrazaosocial.Text = Convert.ToString(read["RazaoSocial"]);
                    txtendereco.Text = Convert.ToString(read["Endereco"]);
                    txtemail.Text = Convert.ToString(read["Email"]);
                    txtnomefantasia.Text = Convert.ToString(read["NomeFantasia"]);
                    txttelefone.Text = Convert.ToString(read["Telefone"]);
                    txtinscricaoestadual.Text = Convert.ToString(read["InscricaoEstadual"]);
                }
                 
            }
            catch
            {
                abrir.Close();
            }
        }
        #endregion

        #region Botao alterar
        private void btnalterar_Click(object sender, EventArgs e)
        {
            btnalterar.Enabled = false;
            
            string parametros = $"update fornecedor set Cnpj = '{txtcnpj.Text}',RazaoSocial = '{txtrazaosocial.Text}',Endereco = '{txtendereco.Text}',Email = '{txtemail.Text}',NomeFantasia = '{txtnomefantasia.Text}',Telefone = '{txttelefone.Text}',InscricaoEstadual = '{txtinscricaoestadual.Text}' where idfornecedor ='{txtid.Text}'";
            conectar.Comm(parametros);
            MessageBox.Show("Fornecedor alterado com sucesso");
            Limpar();
        }
        #endregion
    }
}
