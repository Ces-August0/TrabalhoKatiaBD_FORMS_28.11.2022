using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho.katia
{
    public partial class ProdutoForm2 : Form
    {
        private void ProdutoForm2_Load(object sender, EventArgs e)
        {

        }
        Conexao conectar = new Conexao();
        public ProdutoForm2()
        {
            InitializeComponent();
            btnalterar.Enabled = false;
            panel1.Visible = false;
        }
        public void Limpar()
        {
            txtid.Text = null;
            txtcodigo.Text = null;
            txtdescricao.Text = null;
            txtvalidade.Text = null;
            txtpreco.Text = null;
            txtqtdestoque.Text = null;
            txttipo.Text = null;
            txtmedida.Text = null;
        }

        #region botao inserir
        private void btninserir_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            string parametros = $"insert into produto values('{txtid.Text}','{txtcodigo.Text}','{txtdescricao.Text}','{txtvalidade.Text}','{txtpreco.Text}','{txtqtdestoque.Text}','{txttipo.Text}','{txtmedida.Text}')";
            conectar.Comm(parametros);
            MessageBox.Show("Produto cadastrado com sucesso");
            Limpar();
        }
        #endregion

        #region botao pesquisar
        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            
            btnalterar.Enabled = true;
            btnalterar.Visible = true;
            MySqlConnection abrir = new MySqlConnection("server=localhost;User Id=root;database=cadastro;password=C964625");
            try
            {
                string parametros = $"select * from produto where idproduto = '{txtid.Text}'";
                abrir.Open();

                MySqlCommand cmd = new MySqlCommand(parametros, abrir);
                MySqlDataReader read;

                read = cmd.ExecuteReader();

                while (read.Read())
                {
                    txtcodigo.Text = Convert.ToString(read["Codigo"]);
                    txtdescricao.Text = Convert.ToString(read["Descricao"]);
                    txtvalidade.Text = Convert.ToString(read["Validade"]);
                    txtpreco.Text = Convert.ToString(read["Preco"]);
                    txtqtdestoque.Text = Convert.ToString(read["QtdEstoque"]);
                    txttipo.Text = Convert.ToString(read["Tipo"]);
                    txtmedida.Text = Convert.ToString(read["Medida"]);
                    
                }
            }
            catch
            {
                abrir.Close();
            }
        }
        #endregion

        #region botao excluir
        private void btnexcluir_Click(object sender, EventArgs e)
        {
            string parametros = $"delete from produto where idproduto = '{txtid.Text}'";
            conectar.Comm(parametros);
            MessageBox.Show("Produto excluido com sucesso");
            Limpar();
        }
        #endregion

        #region botao alterar
        private void btnalterar_Click(object sender, EventArgs e)
        {
            btnalterar.Enabled = false;

            string parametros = $"update produto set Codigo = '{txtcodigo.Text}',Descricao = '{txtdescricao.Text}',Validade = '{txtvalidade.Text}',Preco = '{txtpreco.Text}',QtdEstoque = '{txtqtdestoque.Text}',Tipo = '{txttipo.Text}',Medida = '{txtmedida.Text}' where idproduto = '{txtid.Text}'" ;
            conectar.Comm(parametros);
            MessageBox.Show("Produto alterado com sucesso");
            Limpar();
        }
        #endregion

        private void btnalimenticio_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
    }
}
