using MinhaBiblioteca.Controllers;
using MinhaBiblioteca.Models_tabelas_;
using MySql.Data.MySqlClient;
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
    public partial class TelaBusca : Form
    {
        public TelaBusca()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => System.Windows.Forms.Application.Exit();

            viewResult.ReadOnly= true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Livro buscarLivro = new Livro();
            string titulobuscado = txtLTituloBuscado.Text;
            LivrosController lc = new LivrosController();
            DataTable tabela =lc.buscarLivro(titulobuscado);
            viewResult.DataSource = tabela;

        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            
            Owner.Show();
            this.Hide();
        }

        private void viewResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
