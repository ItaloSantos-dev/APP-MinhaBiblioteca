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
    public partial class ConfirmarLogin : Form
    {
        public ConfirmarLogin()
        {
            InitializeComponent();
        }
        

        private void btnConfirmar_Click(object sender, EventArgs e)
        {   //intancia um registro controller para confirmar os dados
            RegistroController rc = new RegistroController();
            if(rc.confirmaDados(Sessao.Usuario, Sessao.Senha, txtUser.Text, txtSenha.Text))
            {
                //se os dados forem confirmados a view retorna ok
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                //se não retorna cancelado para dar erro
                this.DialogResult= DialogResult.Cancel;
            }



        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
