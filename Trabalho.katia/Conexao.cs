using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace Trabalho.katia
{
    public class Conexao
    {
       

        public void Comm(string parametros)
        {
            MySqlConnection abrir = new MySqlConnection("server=localhost;User Id=root;database=bd_cadastro;password=C964625");//alterar senhas dos botoes pesquisar... 
            MySqlCommand cmd = new MySqlCommand(parametros, abrir);                                                      //...para conectar ao seu banco de dados corretamente


            try
            {
                abrir.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERRO: {ex.Message}");
            }
            finally
            {
                abrir.Close();
            }
        }
   }
}
