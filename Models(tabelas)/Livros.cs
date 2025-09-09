using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhaBiblioteca.Models_tabelas_
{
    internal class Livros
    {
        private int idlivro;
        private string autor;
        private string titulo;
        private bool emprestado;

        public int Idlivro { get => idlivro; set=>idlivro = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Titulo { get => titulo; set => titulo=value; }
        public bool Emprestado { get => emprestado; set=>emprestado=value; }

        public DataTable  buscarLivro(string nomeLivroBuscado)
        {
            //obj conexao
            Conexao conect = new Conexao();
            conect.abrirConexao();
            //comando
            string select = "SELECT id_livro, titulo, autor, emprestado FROM livros WHERE titulo like @titulobuscado;";
            MySqlCommand cmd = new MySqlCommand(select, conect.con);
            //parametros
            cmd.Parameters.AddWithValue("@titulobuscado", "%" + nomeLivroBuscado + "%");
            //executando
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            conect.fecharConexao();
            return tabela;

            
        }

        public int addLivro(string _titulo, string _autor)
        {
            Conexao conect = new Conexao();
            conect.abrirConexao();
            string insert = "INSERT INTO livros (id_livro, autor, titulo, emprestado) values (default, @autor, @titulo, 0);";
            MySqlCommand cmd = new MySqlCommand(insert, conect.con);
            cmd.Parameters.AddWithValue("@titulo", _titulo);
            cmd.Parameters.AddWithValue("@autor", _autor);
            int resultado = cmd.ExecuteNonQuery();
            if (resultado > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public void deletarLivro()
        {

        }

        
    }
}
