using MinhaBiblioteca.Controllers;
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
    public partial class TelaProfessor : Form
    {
        LivrosController lc = new LivrosController();
        public TelaProfessor()
        {
            InitializeComponent();
            attLista();
            this.FormClosed += (s, e) => System.Windows.Forms.Application.Exit();

        }
        public void attLista()
        {
            DataTable tabela = lc.exibirLivros();
            viewResult.DataSource = tabela;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TelaAdd telaAdd = new TelaAdd();
            telaAdd.Owner = this;
            telaAdd.Show();
            this.Hide();
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            MinhaBiblioteca telalogin = this.Owner as MinhaBiblioteca;
            telalogin.limpaCampos();
            Owner.Show();
            this.Hide();
            
        }


        private void TelaProfessor_Load(object sender, EventArgs e)
        {

        }

        private void btnPegar_Click(object sender, EventArgs e)
        {
            TelaAdd telaAdd = new TelaAdd();
            telaAdd.ShowDialog();
            attLista();
        }

        private void viewResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            Livro buscarLivro = new Livro();
            string titulobuscado = txtBusca.Text;
            DataTable tabela = lc.buscarLivro(titulobuscado);
            viewResult.DataSource = tabela;
            

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
