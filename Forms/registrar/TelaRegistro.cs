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

namespace MinhaBiblioteca.Forms.registrar
{
    public partial class TelaRegistro : Form
    {
        public TelaRegistro()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => System.Windows.Forms.Application.Exit();
            btnReg.Enabled = false;


        }
        public void tipoDeRegistro()
        {
            if (radioAluno.Checked)
            {
                lbliden.Text = "Matricula:";
            }
            else if (radioProf.Checked)
            {
                lbliden.Text = "Registro";
            }
        }
        public void checarCampos()
        {
            if(txtCpf.Text!="" && txtNome.Text != "" && txtIden.Text != "")
            {
                btnReg.Enabled = true;
            }
        }
        private void radioProf_CheckedChanged(object sender, EventArgs e)
        {
            tipoDeRegistro();
        }

        private void radioAluno_CheckedChanged(object sender, EventArgs e)
        {
            tipoDeRegistro();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            checarCampos();
        }

        private void lbliden_Click(object sender, EventArgs e)
        {

        }

        private void TelaRegistro_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            checarCampos();

        }

        private void txtIden_TextChanged(object sender, EventArgs e)
        {
            checarCampos();

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;
            string identificador = txtIden.Text;
            if (txtCpf.Text == "" || txtNome.Text == "" || txtIden.Text == "")
            {
                MessageBox.Show("Um dos campos está vazio!");
                btnReg.Enabled = false;
            }
            if (radioAluno.Checked)
            {
                Alunos aluno = new Alunos();
                aluno.Nome = nome;
                aluno.Cpf = cpf;
                aluno.Matricula = identificador;
                aluno.cadastrarAluno(aluno);
            }
            else if (radioProf.Checked)
            {
                Professores professor = new Professores();
                professor.Nome = nome;
                professor.Cpf = cpf;
                professor.Registro = identificador;
                professor.registrarProfessor(professor);
            }
            txtNome.Text = "";
            txtCpf.Text = "";
            txtIden.Text = "";

        }

        private void txtCpf_Click(object sender, EventArgs e)
        {
            txtCpf.Select(0, 0);
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }
    }
}
