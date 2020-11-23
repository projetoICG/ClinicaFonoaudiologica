using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.objetos
{
    class Consulta
    {
        private int idConsulta;
        private int idMedico;
        private int idPaciente;
        private string nomePaciente;
        private string horaInicio;
        private string horaFim;
        private string data;
        private string nomeMedico;
        private float valorConsulta;

        public int IdConsulta { get => idConsulta; set => idConsulta = value; }
        public int IdMedico { get => idMedico; set => idMedico = value; }
        public string NomePaciente { get => nomePaciente; set => nomePaciente = value; }
        public string HoraInicio { get => horaInicio; set => horaInicio = value; }
        public string HoraFim { get => horaFim; set => horaFim = value; }
        public string Data { get => data; set => data = value; }
        public string NomeMedico { get => nomeMedico; set => nomeMedico = value; }
        public float ValorConsulta { get => valorConsulta; set => valorConsulta = value; }
        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
    }
}
