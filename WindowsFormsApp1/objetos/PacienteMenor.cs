using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.objetos
{
    public class PacienteMenor:Paciente
    {
        private string nomeMae;
        private string nomePai;
        private string nomeParente;
        private string cpfMae;
        private string cpfPai;
        private string cpfParente;

        public string NomeMae { get => nomeMae; set => nomeMae = value; }
        public string NomePai { get => nomePai; set => nomePai = value; }
        public string NomeParente { get => nomeParente; set => nomeParente = value; }
        public string CpfMae { get => cpfMae; set => cpfMae = value; }
        public string CpfPai { get => cpfPai; set => cpfPai = value; }
        public string CpfParente { get => cpfParente; set => cpfParente = value; }
    }
}
