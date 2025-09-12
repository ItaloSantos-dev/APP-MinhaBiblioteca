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
            Livro livros = new Livro();
            LivrosController lc = new LivrosController();
            DataTable tabela = lc.buscarLivro(titulobuscado);
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
                Livro livro = new Livro();
                livro.Idlivro = id;
                LivrosController lc = new LivrosController();
                lc.deletarLivro(livro);
                txtLTituloBuscado.Text = "";
                viewResult.DataSource = null;

                
            }
        }

        private void txtLTituloBuscado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
