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

namespace WindowsFormsApp1.view.Medico
{
    public partial class SelecionarMedicoConsulta : Form
    {
        private BDMedico bdMedico;
        private List<WindowsFormsApp1.objetos.Medico> listaMedicosNoBanco;
        public WindowsFormsApp1.objetos.Medico RetornarMedico { get; set; }

        public SelecionarMedicoConsulta()
        {
            InitializeComponent();

            bdMedico = new BDMedico();
            listaMedicosNoBanco = new List<WindowsFormsApp1.objetos.Medico>();
            listaMedicosNoBanco = bdMedico.retornarListaMedicos();
            atualizarLista(listaMedicosNoBanco);
        }


        private void atualizarLista(List<WindowsFormsApp1.objetos.Medico> listaMedicos)
        {

            try
            {

                listView1.Items.Clear();
                listView1.Refresh();

                foreach (WindowsFormsApp1.objetos.Medico m in listaMedicos)
                {

                    ListViewItem varItem = new ListViewItem(new string[]
                    {
                        Convert.ToString(m.Id),
                        m.Nome,
                        m.Cpf,
                        m.Email,
                        m.Telefone1,
                        m.Telefone2,
                        m.Funcao
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
                List<WindowsFormsApp1.objetos.Medico> medicos = new List<WindowsFormsApp1.objetos.Medico>();
                if ((medicos = bdMedico.buscarEspecificacaoMedico(comboPesquisar.Text, campoPesquisar.Text)) != null)
                {
                    atualizarLista(medicos);
                }
            }
            else
            {
                atualizarLista(listaMedicosNoBanco);
            }
        }

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            string id;
            try
            {
                id = listView1.SelectedItems[0].Text;
                listaMedicosNoBanco.Clear();
                listaMedicosNoBanco = bdMedico.buscarEspecificacaoMedico("id_medico", id);
                this.RetornarMedico = listaMedicosNoBanco[0];
                this.DialogResult = DialogResult.OK;
                this.Close();
            } catch {
                MessageBox.Show("Selecione um medico");
            }
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
