using MinhaBiblioteca.Models_tabelas_;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhaBiblioteca.Forms
{
    public partial class ConfirmarEmp : Form
    {
        public ConfirmarEmp()
        {
            InitializeComponent();
        }
        public string pegando_dados()
        {
            string senha = txtSenha.Text;
            return senha;

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {   
            string usuario = txtUser.Text;
            string senha = txtSenha.Text;
            Alunos aluno = new Alunos();
            aluno.Nome = usuario;
            aluno.Matricula = senha;
            int validacao = aluno.validarLogin(aluno);
            if (validacao == 1)
            {
                this.DialogResult = DialogResult.OK;
                    this.Close();
                
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido");
            }
        }
    }
}
