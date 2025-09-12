using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinhaBiblioteca.Models_tabelas_
{
    internal class Livro
    {
        private int idlivro;
        private string autor;
        private string titulo;
        private bool emprestado;
        

        public int Idlivro { get => idlivro; set=>idlivro = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Titulo { get => titulo; set => titulo=value; }
        public bool Emprestado { get => emprestado; set=>emprestado=value; }

        



    }
}
