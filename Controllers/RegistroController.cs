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
                if (tipo == "aluno")
                {
                    TelaAluno telaAluno = new TelaAluno();
                    telaAluno.Owner = pai;
                    telaAluno.Show();
                    pai.Hide();

                }
                else if (tipo == "professor")
                {
                    TelaProfessor telaProfessor = new TelaProfessor();
                    telaProfessor.Owner = pai;
                    telaProfessor.Show();
                    pai.Hide();
                }
                else if (tipo == "admin")
                {
                    
                }
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido!");
                
            }


        }
    }
}
