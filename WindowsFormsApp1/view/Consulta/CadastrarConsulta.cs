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

namespace WindowsFormsApp1.view.Consulta
{
    public partial class CadastrarConsulta : Form
    {
        private WindowsFormsApp1.objetos.Medico medico;

        public CadastrarConsulta()
        {
            InitializeComponent();

            medico = new WindowsFormsApp1.objetos.Medico();
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

                    Console.WriteLine(medico.Nome);
                }
            }
        }
    }
}
