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

namespace MinhaBiblioteca.Forms.emp
{
    public partial class TelaEmp : Form
    {

        public void mostrarLivros()
        {
            LivrosController lc = new LivrosController();
            DataTable tabela = lc.dispoEmprestimo();
            viewLivrosDisp.DataSource = tabela;
        }
        
        public TelaEmp( )
        {
            
            InitializeComponent();
            this.FormClosed += (s, e) => System.Windows.Forms.Application.Exit();
            mostrarLivros();
            
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        

        private void btnPegar_Click(object sender, EventArgs e)
        {
            if(viewLivrosDisp.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(viewLivrosDisp.SelectedRows[0].Cells["id_livro"].Value);
                ConfirmarEmp conf_emp = new ConfirmarEmp(id);
                conf_emp.ShowDialog();
                mostrarLivros();


            }
            else
            {
                MessageBox.Show("Selecione uma linha!");
            }
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void TelaEmp_Load(object sender, EventArgs e)
        {

        }
    }
}
