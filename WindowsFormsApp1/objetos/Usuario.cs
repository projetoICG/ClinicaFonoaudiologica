using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.objetos
{
    class Usuario:Pessoa
    {
        private string login;
        private string senha;
        private string dicaSenha;

        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public string DicaSenha { get => dicaSenha; set => dicaSenha = value; }
    }
}
