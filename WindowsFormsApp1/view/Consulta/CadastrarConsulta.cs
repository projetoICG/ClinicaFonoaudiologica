using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Banco_de_Dados;
using WindowsFormsApp1.view.Medico;
using WindowsFormsApp1.objetos;
using WindowsFormsApp1.view.Paciente;

namespace WindowsFormsApp1.view.Consulta
{
    public partial class CadastrarConsulta : Form
    {
        private WindowsFormsApp1.objetos.Medico medico;
        private WindowsFormsApp1.objetos.Paciente paciente;
        private WindowsFormsApp1.objetos.Consulta consulta;
        private BDConsulta bdconsulta;

        public CadastrarConsulta()
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";

            medico = new WindowsFormsApp1.objetos.Medico();
            paciente = new WindowsFormsApp1.objetos.Paciente();
            consulta = new WindowsFormsApp1.objetos.Consulta();
            bdconsulta = new BDConsulta();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        /*
        private void CadastrarConsulta_Load(object sender, EventArgs e)
        {

            BDConsulta bdconsulta = new BDConsulta();
            List<String> listaNomeMedicos = bdconsulta.retornarListaNomeMedicos();

            foreach (String item in listaNomeMedicos)
            {
                comboBoxListaMedicos.Items.Add(item);
            }
            

            
        } */

        private void botaoSelecionarMedico_Click(object sender, EventArgs e)
        {
            using (var form = new SelecionarMedicoConsulta())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    medico = form.RetornarMedico;

                    consulta.NomeMedico = medico.Nome;
                    consulta.IdMedico = medico.Id;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void botaoSelecionarPaciente_Click(object sender, EventArgs e)
        {
            using (var form = new SelecionarPacienteConsulta())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    paciente = form.RetornarPaciente;

                    consulta.NomePaciente = paciente.Nome;
                    consulta.IdPaciente = paciente.Id;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            consulta.HoraInicio = campoHoraInicio.Text;
            consulta.HoraFim = campoHoraFim.Text;
            consulta.ValorConsulta = float.Parse(campoValor.Text);
            //dateTimePicker1.Value = DateTime.ParseExact(consulta.Data, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);
            consulta.Data = Convert.ToString(dateTimePicker1.Text);
            bdconsulta.cadastrarConsulta(consulta);

            this.Close();
        }
    }
}
