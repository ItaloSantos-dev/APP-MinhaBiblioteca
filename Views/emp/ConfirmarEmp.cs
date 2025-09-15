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
            RegistroController rc = new RegistroController();
            if(rc.confirmaDados(Sessao.Usuario, Sessao.Senha, txtUser.Text, txtSenha.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                this.DialogResult= DialogResult.Cancel;
            }



        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
