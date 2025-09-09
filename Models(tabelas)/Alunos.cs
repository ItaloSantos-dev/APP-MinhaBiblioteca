using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca.Models_tabelas_
{
    internal class Alunos
    {
        private int idaluno;
        private string cpf;
        private int matricula;
        private int livropego;

        public int Idaluno { get => idaluno; set => idaluno = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public int Matricula { get => matricula; set => matricula = value; }
        public int Livropego { get => livropego; set => livropego = value; }

        public int  validarLogin(string _cpf, string _senha)
        {
            Conexao conect = new Conexao();
            conect.abrirConexao();
            string select = "SELECT *from alunos where cpf = @cpf AND matricula = @matricula";
            MySqlCommand cmd = new MySqlCommand (select, conect.con);
            cmd.Parameters.AddWithValue ("@cpf", _cpf);
            cmd.Parameters.AddWithValue("@matricula", _senha);

            MySqlDataReader reader = cmd.ExecuteReader ();

            if (reader.Read())
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
