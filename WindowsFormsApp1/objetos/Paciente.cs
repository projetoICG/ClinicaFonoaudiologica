using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.objetos
{
    class Paciente:Pessoa
    {
        private string observacoes;

        public string Observacoes { get => observacoes; set => observacoes = value; }
    }
}
