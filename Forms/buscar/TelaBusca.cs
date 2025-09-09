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
            Livros buscarLivro = new Livros();
            string titulobuscado = txtLTituloBuscado.Text;
            DataTable tabela =buscarLivro.buscarLivro(titulobuscado);
            viewResult.DataSource = tabela;

        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            
            TelaAluno telaAluno = new TelaAluno();
            Owner.Show();
            this.Hide();
        }
    }
}
