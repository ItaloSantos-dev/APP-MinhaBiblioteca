using MinhaBiblioteca.Models_tabelas_;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
            //executando o comando
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable tabela = new DataTable();
            //pega os dados buscados e adpta para uma tabela
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
            //retorna o quantidade de linhas afetadas
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


        //Confirma se o usuario possui ou não um livro emprestado e retorna true ou false
        private bool confirmarPossibilidadeUsuario(Usuario usuario)
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
        //Confrima se o livro selecionado esta em um emprestimo ou não
        public bool confirmarPossibilidadeLivros(Livro livro)
        {
            conect.abrirConexao();
            string select = "SELECT *FROM livros WHERE id_livro = @id;";
            MySqlCommand cmd = new MySqlCommand(select, conect.con);
            cmd.Parameters.AddWithValue("@id", livro.Idlivro);
            MySqlDataReader reader = cmd.ExecuteReader();
            conect.fecharConexao();
            if(reader.Read())
            {
                var conf = Convert.ToInt32(  reader["emprestado"]);
                if(conf == 0)
                {
                    
                    return true ;
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
            //verifica se o usuario e o livro pode ser alocados para um emprestimo
            if (confirmarPossibilidadeUsuario(usuario))
            {
                if (confirmarPossibilidadeLivros(livro))
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
                    MessageBox.Show("O livro que você selecionou ja está em um empréstimo!");
                }
            }
            else
            {
                MessageBox.Show("Você precisar encerrar seu empréstimo atual para fazer outro!");
            }
            
        }

        public DataTable exibirLivros()
        {
            //Pega todas as linhas da tabela livros e adapta para uma tabela 
            conect.abrirConexao();
            string select = "SELECT *FROM livros;";
            MySqlCommand cmd = new MySqlCommand(select, conect.con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            conect.fecharConexao();
            return tabela;
        }

        public void devolverLivro()
        {
            //Basicamente faz as verificações necessarias para ver se o usuario possui um livro em emprestimo ou não e se o livro realmente existe no banco de dados
            conect.abrirConexao();
            string select = "SELECT livro_pego FROM usuarios WHERE identificador = @idu;";
            MySqlCommand cmd = new MySqlCommand( select, conect.con);
            cmd.Parameters.AddWithValue("idu", Sessao.Senha);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                
                var idl = reader["livro_pego"];
                if (idl != DBNull.Value)
                {   
                    int id = Convert.ToInt32(reader["livro_pego"]);

                    Livro livro = new Livro(id, "", "");

                    reader.Close();
                    string update = "UPDATE livros SET emprestado = 0 WHERE id_livro = @idl;";
                    cmd = new MySqlCommand(update, conect.con);
                    cmd.Parameters.AddWithValue("idl", livro.Idlivro);
                    int result1 = cmd.ExecuteNonQuery();
                    if (result1 > 0)
                    {
                        update = "UPDATE usuarios SET livro_pego = NULL WHERE identificador = @idu;";
                        cmd = new MySqlCommand(update, conect.con);
                        cmd.Parameters.AddWithValue("idu", Sessao.Senha);
                        int result2 = cmd.ExecuteNonQuery();
                        if (result2 > 0)
                        {
                            MessageBox.Show("Livro devolvido com sucesso");
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel encontrar este usuario");

                        }
                    }
                    else
                    {
                            MessageBox.Show("Não foi possivel encontrar o id deste livro");

                    }
                }
                else
                {
                    MessageBox.Show("Voce não pegou nenhum emprestimo");
                }
                

            }
            else
            {
                MessageBox.Show("Deu erro 3");

            }


        }

    }
}
