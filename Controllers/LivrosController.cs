using MinhaBiblioteca.Models_tabelas_;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhaBiblioteca.Controllers
{
    internal class LivrosController
    {
        Conexao conect = new Conexao();
        public DataTable buscarLivro(string nomeLivroBuscado)
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

        public void addLivro(Livro livro)
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
        public void deletarLivro(Livro livro)
        {
            conect.abrirConexao();
            string delete = "DELETE FROM livros WHERE id_livro = @id;";
            MySqlCommand cmd = new MySqlCommand(delete, conect.con);
            cmd.Parameters.AddWithValue("@id", livro.Idlivro);
            int resultado = cmd.ExecuteNonQuery();
            conect.fecharConexao();
            if (resultado > 0)
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

        private bool confirmarPossibilidade(Usuario usuario)
        {
            conect.abrirConexao();
            string select = "SELECT *FROM usuarios WHERE identificador = @identi;";
            MySqlCommand cmd = new MySqlCommand( select, conect.con);
            cmd.Parameters.AddWithValue("@identi", usuario.Identificador);
            MySqlDataReader reader = cmd.ExecuteReader();
            conect.fecharConexao();
            if (reader.Read()) { 
                var confi = reader["livro_pego"];
                if (confi == DBNull.Value)
                {
                    
                    return true;
                }
                else
                {
                    
                    return false;
                }
                
            
            }
            else
            {
                
                return false;
            }

        }

        public void pegarEmp(Livro livro, Usuario usuario)
        {
            
            bool confirmacao = confirmarPossibilidade(usuario);

            if (confirmacao)
            {
                conect.abrirConexao();
                string update = "UPDATE livros SET emprestado = 1 where id_livro = @_id;";
                MySqlCommand cmd = new MySqlCommand(update, conect.con);
                cmd.Parameters.AddWithValue("@_id", livro.Idlivro);
                int resultado1 = cmd.ExecuteNonQuery();

                update = "UPDATE usuarios SET livro_pego = @_id where identificador = @_identificador;";
                cmd = new MySqlCommand(update, conect.con);
                cmd.Parameters.AddWithValue("@_id", livro.Idlivro);
                cmd.Parameters.AddWithValue("@_identificador", usuario.Identificador);
                int resultado2 = cmd.ExecuteNonQuery();

                conect.fecharConexao();
                if (resultado1 > 0 && resultado2 > 0)
                {


                    MessageBox.Show("Livro pego emprestado com sucesso");
                }
                else
                {
                    MessageBox.Show("Não foi possível concluir o empréstimo");
                }
            }
            else
            {
                MessageBox.Show("Você precisa devolver o livro que você pegou, para fazer outro empréstimo!");
            }
        }

    }
}
