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

namespace MinhaBiblioteca
{
    public partial class TelaProfessor : Form
    {
        //intanciando um livrosController
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

        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            //volta para a tela pai
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
            //intancia a view de adicionar livro
            TelaAdd telaAdd = new TelaAdd();
            telaAdd.ShowDialog();
            attLista();
        }

        private void viewResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            //atualiza a lista a cada valor escrito na busca
            string titulobuscado = txtBusca.Text;
            DataTable tabela = lc.buscarLivro(titulobuscado);
            viewResult.DataSource = tabela;
            

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //verifica se um livro foi selecionado
            if (viewResult.SelectedRows.Count > 0)
            {
                //captura os valores respectivos da linha selecionada
                int id = Convert.ToInt32(viewResult.SelectedRows[0].Cells["id_livro"].Value);
                string titulo = viewResult.SelectedRows[0].Cells["titulo"].Value.ToString();
                string autor = viewResult.SelectedRows[0].Cells["autor"].Value.ToString();
                //intancia a view de confirmar login
                ConfirmarLogin conf_emp = new ConfirmarLogin();
                DialogResult result = conf_emp.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //intancia um objteto livro com os valortes capturados
                    Livro livro = new Livro(id, titulo,autor);
                    //chama a função passando o objeto criado
                    lc.deletarLivro(livro);
                    attLista();

                }
                else
                {
                    MessageBox.Show("Usuario ou senha invalido");
                }



            }
            else
            {
                MessageBox.Show("Selecione uma linha!");
            }
        }
    }
}
