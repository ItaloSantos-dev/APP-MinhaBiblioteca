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

namespace MinhaBiblioteca.Forms.emp
{
    public partial class TelaEmp : Form
    {
        public TelaEmp()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => System.Windows.Forms.Application.Exit();
            Livros livro = new Livros();
            DataTable tabela = livro.dispoEmprestimo();
            viewLivrosDisp.DataSource = tabela;
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnPegar_Click(object sender, EventArgs e)
        {
            if(viewLivrosDisp.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = viewLivrosDisp.SelectedRows[0];
                int id = Convert.ToInt32(linha.Cells["id_livro"].Value);
                Livros livro = new Livros();
                livro.pegarEmp(id);
                DataTable tabela = livro.dispoEmprestimo();
                viewLivrosDisp.DataSource = tabela;

            }
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }
    }
}
