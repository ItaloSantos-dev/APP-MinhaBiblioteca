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
            Livros livros = new Livros();
            livros.Titulo = txtTitulo.Text;
            livros.Autor = txtAutor.Text;
            livros.addLivro(livros);
            txtAutor.Text = "";
            txtTitulo.Text = "";
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            Owner.Show();
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
