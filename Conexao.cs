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
            MySqlConnection abrir = new MySqlConnection("server=localhost;User Id=root;database=cadastro;password=C964625");
            MySqlCommand cmd = new MySqlCommand(parametros, abrir);
            
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
