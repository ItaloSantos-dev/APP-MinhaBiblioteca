using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhaBiblioteca
{
    internal class Conexao
    {
        public string conec = "Server=localhost;Database=biblioteca;User ID=root;Password=;";


        public MySqlConnection con = null;

        public void abrirConexao()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Open();
            }
            catch (Exception ex) {
                MessageBox.Show("Erro na conexão" + ex.Message);
            
            }


        }

        public void fecharConexao()
        {
            con = new MySqlConnection(conec);
            con.Close();
        }
    }
}
