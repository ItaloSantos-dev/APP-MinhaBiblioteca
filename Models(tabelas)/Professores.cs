using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhaBiblioteca.Models_tabelas_
{
    internal class Professores
    {
        private int id_professor;
        private string nome;
        private string cpf;
        private string registro;
        Conexao conect = new Conexao();

        public int Id_professor { get => id_professor; set=>id_professor = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Registro { get => registro; set => registro = value; }

        public int validaLogin(Professores professor)
        {
            conect.abrirConexao();
            string select = "SELECT *FROM professores WHERE registro = @registro;";
            MySqlCommand cmd = new MySqlCommand(select, conect.con);
            cmd.Parameters.AddWithValue("@registro", professor.Registro);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        public void registrarProfessor(Professores professor)
        {
            conect.abrirConexao();
            string insert = "INSERT INTO professores (id_professor, nome, cpf, registro)" +
                "VALUES (DEFAULT, @nome, @cpf, @registro);";
            MySqlCommand cmd = new MySqlCommand (insert, conect.con);
            cmd.Parameters.AddWithValue("@nome", professor.Nome);
            cmd.Parameters.AddWithValue("@cpf", professor.Cpf);
            cmd.Parameters.AddWithValue("@registro", professor.Registro);
            int resultado = cmd.ExecuteNonQuery();
            conect.fecharConexao();
            if (resultado > 0)
            {
                MessageBox.Show("Professor registrado com sucesso!");

            }
            else
            {
                MessageBox.Show("Falaha ao registrar o professor!");

            }


        }

    }
}
