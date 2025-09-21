using MinhaBiblioteca.Models_tabelas_;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhaBiblioteca.Controllers
{
    internal class RegistroController
    {
        Conexao conect = new Conexao();
        //Faz um insert na tabela usuarios
        public void Registrar(Usuario usuario)
        {
            conect.abrirConexao();
            string insert = "INSERT INTO usuarios (id_reg, tipo, nome, identificador, cpf, livro_pego) VALUES" +
                                                  "(DEFAULT, @tipo, @nome, @identificador, @cpf, NULL);";

            MySqlCommand cmd = new MySqlCommand(insert, conect.con);
            cmd.Parameters.AddWithValue("@tipo", usuario.Tipo);
            cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@identificador", usuario.Identificador);
            cmd.Parameters.AddWithValue("@cpf", usuario.Cpf);

            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                MessageBox.Show(usuario.Tipo + " cadastrado com sucesso");

            }
            else
            {
                MessageBox.Show("Falha ao cadastrar " + usuario.Tipo);

            }




        }

        //Faz um select buscando professores ou alunos ou a conta admin com os dados enviados
        public void validarLogin(string usuario, string senha, Form pai)
        {
            conect.abrirConexao();
            string select = "SELECT *FROM usuarios WHERE (nome = @usuario AND identificador = @senha)" +
                            "or (tipo='admin' and cpf=@usuario and identificador=@senha ); ";
            MySqlCommand cmd = new MySqlCommand( select, conect.con);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);
            MySqlDataReader reader = cmd.ExecuteReader();
            bool result = reader.Read();
            if(result)
            {
                string tipo = reader["tipo"].ToString();
                Sessao.Usuario = usuario;
                Sessao.Senha = senha;
                //se o tipo for aluno abre a view TelaAluno
                if (tipo == "aluno")
                {
                    TelaAluno telaAluno = new TelaAluno();
                    telaAluno.Owner = pai;
                    telaAluno.Show();
                    pai.Hide();

                }
                //se o tipo for Professor abre a view TelaProfessor

                else if (tipo == "professor")
                {
                    TelaProfessor telaProfessor = new TelaProfessor();
                    telaProfessor.Owner = pai;
                    telaProfessor.Show();
                    pai.Hide();
                }
                else if (tipo == "admin")
                {
                    MessageBox.Show("Iai ADM");
                }
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido!");
                
            }


        }
        //Compara os dados recebidos por parametros com os dados recebidos na classe estatica sessão que foi preenchida no ato de login
        public bool confirmaDados(string userLog, string senhaLog, string userDig, string senhaDig)
        {
            if( userLog==userDig && senhaLog == senhaDig) { return true; }
            else{ return false; }
                
        }
    }
}
