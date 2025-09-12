using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca.Models_tabelas_
{
    public static class Sessao
    {
        private static string usuario;
        private static string senha;

        public static string Usuario { get => usuario; set => usuario = value; }
        public static string Senha { get => senha; set => senha = value; }

    }
}
