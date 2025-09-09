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
        public TelaProfessor()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => System.Windows.Forms.Application.Exit();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TelaAdd telaAdd = new TelaAdd();
            telaAdd.Owner = this;
            telaAdd.Show();
            this.Hide();
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaDel teladel = new TelaDel();
            teladel.Owner = this;
            teladel.Show();
            this.Hide();
        }
    }
}
