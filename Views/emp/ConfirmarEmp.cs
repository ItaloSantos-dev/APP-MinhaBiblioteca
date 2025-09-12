using MinhaBiblioteca.Controllers;
using MinhaBiblioteca.Models_tabelas_;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhaBiblioteca.Forms
{
    public partial class ConfirmarEmp : Form
    {
        private int id;
        public ConfirmarEmp(int id_livro)
        {
            id = id_livro;
            InitializeComponent();
        }
        

        private void btnConfirmar_Click(object sender, EventArgs e)
        {   
            string usuariodig = txtUser.Text;
            string senhadig = txtSenha.Text;
            string usuariologado = Sessao.Usuario;
            string senhalogada = Sessao.Senha;
            if(usuariologado == usuariodig && senhalogada == senhadig)
            {
                Livro livro = new Livro();
                livro.Idlivro = id;
                Usuario usuario = new Usuario();
                usuario.Identificador = senhalogada;
                LivrosController lc = new LivrosController();
                lc.pegarEmp(livro, usuario);
                this.Hide();
                


            }
            else
            {
                MessageBox.Show("Usuario ou senha inválido!");
            }



        }
    }
}
