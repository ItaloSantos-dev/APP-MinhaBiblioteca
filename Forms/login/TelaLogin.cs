using MinhaBiblioteca.Forms.registrar;
using MinhaBiblioteca.Models_tabelas_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhaBiblioteca
{
    public partial class MinhaBiblioteca : Form
    {
        public MinhaBiblioteca()
        {
            InitializeComponent();
            
            btnEntrar.Enabled = false;
           
        }
        public void limpaCampos()
        {
            txtSenha.Text = "";
            txtUser.Text = "";
        }
        public void ativandoBtnEntrar()
        {
            if (txtSenha.Text!="" && txtUser.Text != "")
            {
                btnEntrar.Enabled=true;
            }
            else
            {
                btnEntrar.Enabled=false;
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            ativandoBtnEntrar();
            txtSenha.UseSystemPasswordChar = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ativandoBtnEntrar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string senha = txtSenha.Text;
            if (usuario=="professor")
            {
                Professores professor = new Professores();
                professor.Registro = senha;
                int validacao = professor.validaLogin(professor);
                if (validacao==1)
                {
                    TelaProfessor telaProfessor = new TelaProfessor();
                    telaProfessor.Owner = this;
                    this.Hide();
                    telaProfessor.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválido");

                }
            }
            else
            {
                Alunos aluno = new Alunos();
                aluno.Nome = usuario;
                aluno.Matricula = senha;
                int validacao = aluno.validarLogin(aluno);
                if (validacao == 1)
                {
                    this.Hide();
                    TelaAluno telaaluno = new TelaAluno();
                    telaaluno.Owner = this;
                    telaaluno.Show();
                    
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválido");
                }
            }
            
           
           


        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           TelaRegistro telaRegistro = new TelaRegistro();
            telaRegistro.Owner = this;
            this.Hide();
            telaRegistro.Show();
        }
    }
}
