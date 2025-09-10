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
        Conexao conect = new Conexao();

        public int Idlivro { get => idlivro; set=>idlivro = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Titulo { get => titulo; set => titulo=value; }
        public bool Emprestado { get => emprestado; set=>emprestado=value; }

        public DataTable  buscarLivro(string nomeLivroBuscado)
        {
            //obj conexao

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

        public void addLivro(Livros livro)
        {
            
            conect.abrirConexao();
            string insert = "INSERT INTO livros (id_livro, autor, titulo, emprestado) values (default, @autor, @titulo, 0);";
            MySqlCommand cmd = new MySqlCommand(insert, conect.con);
            cmd.Parameters.AddWithValue("@titulo", livro.Titulo);
            cmd.Parameters.AddWithValue("@autor", livro.Autor);
            int resultado = cmd.ExecuteNonQuery();
            conect.fecharConexao();
            if (resultado > 0)
            {
                MessageBox.Show("Livro adicionado com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao adicionar o livro!");

            }
        }
        public void deletarLivro(int _id)
        {
            conect.abrirConexao();
            string delete = "DELETE FROM livros WHERE id_livro = @id;";
            MySqlCommand cmd = new MySqlCommand(delete, conect.con);
            cmd.Parameters.AddWithValue("@id", _id);
            int resultado = cmd.ExecuteNonQuery();
            conect.fecharConexao();
            if(resultado > 0)
            {
                MessageBox.Show("Livro excluído com sucesso!");

            }
            else
            {
                MessageBox.Show("Falha ao excluir o livro selecionado!");

            }

        }

        public DataTable dispoEmprestimo()
        {
            conect.abrirConexao();
            string select = "SELECT id_livro, titulo, autor, emprestado FROM livros where emprestado = 0";
            MySqlCommand cmd = new MySqlCommand(select, conect.con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            conect.fecharConexao();
            return tabela;


        }

        public void pegarEmp(int _id)
        {
            conect.abrirConexao();
            string update = "UPDATE livros SET emprestado = 1 where id_livro = @_id;";
            MySqlCommand cmd = new MySqlCommand(update, conect.con);
            cmd.Parameters.AddWithValue("@_id", _id);
            int resultado = cmd.ExecuteNonQuery();
            conect.fecharConexao();
            if(resultado > 0)
            {
                MessageBox.Show("Livro pego emprestado com sucesso");
            }
            else
            {
                MessageBox.Show("Não foi possível concluir o empréstimo");

            }
        }



    }
}
