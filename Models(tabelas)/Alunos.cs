using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhaBiblioteca.Models_tabelas_
{
    internal class Alunos
    {
        private int idaluno;
        private string nome;
        private string cpf;
        private string matricula;
        private int livropego;
        Conexao conect = new Conexao();

        public int Idaluno { get => idaluno; set => idaluno = value; }
        public string Nome { get => nome; set=>nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public int Livropego { get => livropego; set => livropego = value; }

        public int  validarLogin(Alunos aluno)
        {
            
            conect.abrirConexao();
            string select = "SELECT *from alunos where nome = @nome AND matricula = @matricula";
            MySqlCommand cmd = new MySqlCommand (select, conect.con);
            cmd.Parameters.AddWithValue ("@nome", aluno.Nome);
            cmd.Parameters.AddWithValue("@matricula", aluno.Matricula);
            
            MySqlDataReader reader = cmd.ExecuteReader ();
            conect.fecharConexao();
            if (reader.Read())
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void cadastrarAluno(Alunos aluno)
        {
            conect.abrirConexao();
            string insert = "INSERT INTO alunos (id_aluno, nome, cpf, matricula, livro_pego ) VALUES " +
                "(DEFAULT, @nome, @cpf, @matricula, NULL);";
            MySqlCommand cmd = new MySqlCommand (insert, conect.con);
            cmd.Parameters.AddWithValue("@nome", aluno.Nome);
            cmd.Parameters.AddWithValue("@cpf", aluno.Cpf);
            cmd.Parameters.AddWithValue("@matricula", aluno.Matricula);
            int resultado = cmd.ExecuteNonQuery();
            conect.fecharConexao();
            if (resultado > 0)
            {
                MessageBox.Show("Aluno registrado com sucesso!");

            }
            else
            {
                MessageBox.Show("Falaha ao registrar o aluno!");

            }


        }
    }
}
