using MinhaBiblioteca.Controllers;
using MinhaBiblioteca.Models_tabelas_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhaBiblioteca
{
    public partial class TelaAdd : Form
    {
        public TelaAdd()
        {
            InitializeComponent();
            btnAdicionar.Enabled = false;
            this.FormClosed += (s, e) => System.Windows.Forms.Application.Exit();

        }
        public void verificaCampos()
        {
            if(txtAutor.Text!="" && txtTitulo.Text != "")
            {
                btnAdicionar.Enabled = true;
            }
            else
            {
                btnAdicionar.Enabled = false;
            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //instancia um livro com os valores digitado em cada campo
            Livro livros = new Livro(0, txtTitulo.Text, txtAutor.Text);
            LivrosController lc = new LivrosController();
            //chama a função de adicionar livro passando o livro criado
            lc.addLivro(livros);
            //limpa os campos
            txtAutor.Text = "";
            txtTitulo.Text = "";
            this.Hide();

        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            verificaCampos();
        }

        private void txtAutor_TextChanged(object sender, EventArgs e)
        {
            verificaCampos();

        }
    }
}
