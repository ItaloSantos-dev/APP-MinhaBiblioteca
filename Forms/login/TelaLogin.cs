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
            if (usuario == "professor")
            {
                TelaProfessor telaProfessor = new TelaProfessor();
                telaProfessor.Owner = this;
                this.Hide();
                telaProfessor.Show();
            }
            else
            {
                Alunos alunos = new Alunos();
                int validacao = alunos.validarLogin(usuario, senha);
                if (validacao == 1)
                {
                    this.Hide();
                    TelaAluno telaaluno = new TelaAluno();
                    telaaluno.Owner = this;//define telalogin como pai de telaaluno
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
    }
}
