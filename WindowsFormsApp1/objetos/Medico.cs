using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.objetos
{
    class Medico:Pessoa
    {
        private string funcao;
        private string conselho;
        private string nConselho;
        private string formacao;
        public string NConselho { get => nConselho; set => nConselho = value; }
        public string Formacao { get => formacao; set => formacao = value; }
        public string Conselho { get => conselho; set => conselho = value; }
        public string Funcao { get => funcao; set => funcao = value; }
    }
}
