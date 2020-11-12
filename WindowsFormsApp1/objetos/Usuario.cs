using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.objetos
{
    public class Usuario
    {
        private int id;
        private string funcao;
        private string login;
        private string senha;
        private string dicaSenha;
        private string emailRecuperacao;
        private string nome;

        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public string EmailRecuperacao { get => emailRecuperacao; set => emailRecuperacao = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Funcao { get => funcao; set => funcao = value; }
        public string DicaSenha { get => dicaSenha; set => dicaSenha = value; }
        public int Id { get => id; set => id = value; }
    }
}
