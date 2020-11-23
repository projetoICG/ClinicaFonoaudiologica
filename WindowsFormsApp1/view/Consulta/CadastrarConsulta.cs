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

namespace WindowsFormsApp1.view.Consulta
{
    public partial class CadastrarConsulta : Form
    {
        public CadastrarConsulta()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarConsulta_Load(object sender, EventArgs e)
        {

            BDConsulta bdconsulta = new BDConsulta();
            List<String> listaNomeMedicos = bdconsulta.retornarListaNomeMedicos();

            foreach (String item in listaNomeMedicos)
            {
                comboBoxListaMedicos.Items.Add(item);
            }
            

            
        }
    }
}
