using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.objetos
{
    class Pessoa
    {
        private string cpf;
        private string rg;
        private string nome;
        private char sexo;
        //false == mulher true==homem
        private string rua;
        private string bairro;
        private string numero;
        private string complemento;
        private string telefone1;
        private string telefone2;
        private string email;
        private string dataNascimento;

        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Telefone1 { get => telefone1; set => telefone1 = value; }
        public string Telefone2 { get => telefone2; set => telefone2 = value; }
        public string Email { get => email; set => email = value; }
        public string DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string Rg { get => rg; set => rg = value; }
    }
}
