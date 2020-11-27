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

namespace WindowsFormsApp1.view.Paciente
{
    public partial class SelecionarPacienteConsulta : Form
    {
        private BDPaciente bdPaciente;
        private List<WindowsFormsApp1.objetos.Paciente> listaPacientesNoBanco;
        public WindowsFormsApp1.objetos.Paciente RetornarPaciente { get; set; }

        public SelecionarPacienteConsulta()
        {
            InitializeComponent();

            bdPaciente = new BDPaciente();
            listaPacientesNoBanco = new List<WindowsFormsApp1.objetos.Paciente>();
            listaPacientesNoBanco = bdPaciente.retornarListaPacientes();
            atualizarLista(listaPacientesNoBanco);
        }


        private void atualizarLista(List<WindowsFormsApp1.objetos.Paciente> listaPacientes)
        {

            try
            {

                listView1.Items.Clear();
                listView1.Refresh();

                foreach (WindowsFormsApp1.objetos.Paciente m in listaPacientes)
                {

                    ListViewItem varItem = new ListViewItem(new string[]
                    {
                        Convert.ToString(m.Id),
                        m.Nome,
                        m.Cpf,
                        m.Email,
                        m.Telefone1,
                        m.Telefone2,
                        m.Rg
                    });
                    listView1.Items.Add(varItem);
                }

            }
            catch (Exception j)
            {
                Console.WriteLine(j);
            }
        }

        private void botaoPesquisar_Click(object sender, EventArgs e)
        {
            if (campoPesquisar.Text != "")
            {
                List<WindowsFormsApp1.objetos.Paciente> pacientes = new List<WindowsFormsApp1.objetos.Paciente>();
                if ((pacientes = bdPaciente.buscarEspecificacaoPaciente(comboPesquisar.Text, campoPesquisar.Text)) != null)
                {
                    atualizarLista(pacientes);
                }
            }
            else
            {
                atualizarLista(listaPacientesNoBanco);
            }
        }

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            string id;
            try
            {
                id = listView1.SelectedItems[0].Text;
                listaPacientesNoBanco.Clear();
                listaPacientesNoBanco = bdPaciente.buscarEspecificacaoPaciente("id_paciente", id);
                this.RetornarPaciente = listaPacientesNoBanco[0];
                this.DialogResult = DialogResult.OK;
                this.Close();
            } catch {
                MessageBox.Show("Selecione um paciente");
            }
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void botaoPesquisar_Click_1(object sender, EventArgs e)
        {
            if (campoPesquisar.Text != "")
            {
                List<WindowsFormsApp1.objetos.Paciente> pacientes = new List<WindowsFormsApp1.objetos.Paciente>();
                if ((pacientes = bdPaciente.buscarEspecificacaoPaciente(comboPesquisar.Text, campoPesquisar.Text)) != null)
                {
                    atualizarLista(pacientes);
                }
            }
            else
            {
                atualizarLista(listaPacientesNoBanco);
            }
        }
    }
}
