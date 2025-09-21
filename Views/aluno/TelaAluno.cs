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
        //intanciando o objeto lc
        LivrosController lc = new LivrosController();

        public TelaAluno()
        {
            
            InitializeComponent();
            attLista();
            this.FormClosed += (s, e) => System.Windows.Forms.Application.Exit();
            

        }
        public void attLista()
        {
            //função que atualisa a lista
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
            //salva o titulo buscado a cada mudança do campo e chama a função buscarlivro do livroscontroller
            string titulobuscado = txtBusca.Text;
            DataTable tabela = lc.buscarLivro(titulobuscado);
            viewResult.DataSource = tabela;
        }

        private void btnPegar_Click(object sender, EventArgs e)
        {
            //verifica se tem uma linha selecionada
            if (viewResult.SelectedRows.Count > 0)
            {
                //pega os valores dos campos da linha selecionada
                int id = Convert.ToInt32(viewResult.SelectedRows[0].Cells["id_livro"].Value);
                string titulo = viewResult.SelectedRows[0].Cells["titulo"].Value.ToString();
                string autor = viewResult.SelectedRows[0].Cells["autor"].Value.ToString();

                //instancia a view de conrfirmar login
                ConfirmarLogin conf_emp = new ConfirmarLogin();
                DialogResult result =  conf_emp.ShowDialog();
                //verifica se a view retornou ok
                if (result == DialogResult.OK) {
                    //intancia um objeto livro com os valores pegos anteriormente
                    Livro livro = new Livro(id, titulo, autor);
                    //intancia um objeto usuario com os valores da sessão
                    Usuario usuario = new Usuario(0, Sessao.Usuario,"","", Sessao.Senha);
                    lc.pegarEmp(livro, usuario);
                    //atualiza a lista depois de pegar o livro emprestado
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

        private void viewResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            lc.devolverLivro();
            attLista();
        }
    }
}
