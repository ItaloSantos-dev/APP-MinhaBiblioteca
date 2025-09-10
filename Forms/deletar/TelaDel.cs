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
    public partial class TelaDel : Form
    {
        public TelaDel()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => System.Windows.Forms.Application.Exit();

        }

        private void viewResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string titulobuscado = txtLTituloBuscado.Text;
            Livros livros = new Livros();
            DataTable tabela = livros.buscarLivro(titulobuscado);
            viewResult.DataSource = tabela;

        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(viewResult.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = viewResult.SelectedRows[0];
                int id = Convert.ToInt32(linha.Cells["id_livro"].Value);
                Livros livros = new Livros();
                livros.deletarLivro(id);
                txtLTituloBuscado.Text = "";
                viewResult.DataSource = null;

                
            }
        }

        private void txtLTituloBuscado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
