using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca.Models_tabelas_
{
    internal class Usuario
    {
        private int id;
        private string nome;
        private string cpf;
        private string tipo;
        private string identificador;
        private int livro_pego;

        public int Id { get => id; set =>id = value; }
        public string Nome { get => nome; set=> nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Tipo { get => tipo; set=>tipo=value; }
        public string Identificador { get => identificador; set=> identificador = value; }
        private int Livro_pego { get => livro_pego; set => livro_pego = value; }
    }
}
