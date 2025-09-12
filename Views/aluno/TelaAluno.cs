using MinhaBiblioteca.Forms.emp;
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
        
        public TelaAluno()
        {
            
            InitializeComponent();
            this.FormClosed += (s, e) => System.Windows.Forms.Application.Exit();
            

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            TelaBusca telabusca = new TelaBusca();
            telabusca.Owner = this;
            telabusca.Show();
            this.Hide();

        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            
            TelaEmp telaemp = new TelaEmp();
            telaemp.Owner= this;
            telaemp.Show();
            this.Hide();
            
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            MinhaBiblioteca telalogin = new MinhaBiblioteca();
            this.Hide();
            Owner.Show();


            

        }
    }
}
