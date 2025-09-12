using MinhaBiblioteca.Controllers;
using MinhaBiblioteca.Forms;
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
using static System.Net.Mime.MediaTypeNames;

namespace MinhaBiblioteca
{
    public partial class TelaAluno : Form
    {
        LivrosController lc = new LivrosController();

        public TelaAluno()
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


        private void btnEsc_Click(object sender, EventArgs e)
        {
            MinhaBiblioteca telalogin = new MinhaBiblioteca();
            this.Hide();
            Owner.Show();


            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Livro buscarLivro = new Livro();
            string titulobuscado = txtBusca.Text;
            DataTable tabela = lc.buscarLivro(titulobuscado);
            viewResult.DataSource = tabela;
        }

        private void btnPegar_Click(object sender, EventArgs e)
        {
            if (viewResult.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(viewResult.SelectedRows[0].Cells["id_livro"].Value);
                ConfirmarEmp conf_emp = new ConfirmarEmp(id);
                conf_emp.ShowDialog();
                attLista();


            }
            else
            {
                MessageBox.Show("Selecione uma linha!");
            }
        }

        private void viewResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
