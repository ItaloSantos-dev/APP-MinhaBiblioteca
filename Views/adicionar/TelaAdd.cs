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
            Livro livros = new Livro();
            livros.Titulo = txtTitulo.Text;
            livros.Autor = txtAutor.Text;
            LivrosController lc = new LivrosController();
            lc.addLivro(livros);
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
