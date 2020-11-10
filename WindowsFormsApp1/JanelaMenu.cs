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
using WindowsFormsApp1.objetos;

namespace WindowsFormsApp1
{
    public partial class JanelaMenu : Form
    {
        public JanelaMenu()
        {
            InitializeComponent();
            this.CenterToScreen();
            
        }
        public bool operacaoConfirmada()
        {
            return true;
        }


        public static bool executar()
        {
            JanelaMenu janela2 = new JanelaMenu();
            janela2.Visible = true;

            return janela2.operacaoConfirmada();
        }

       
        private void Janela2_Load(object sender, EventArgs e)
        {

        }

     
        private void aaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cancelarConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarPaciente cadastrarpaciente = new CadastrarPaciente();
            cadastrarpaciente.Show();
        }

        private void médicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarMedico cadastrarmedico = new CadastrarMedico();
            cadastrarmedico.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void JanelaMenu_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Tem certeza que deseja voltar a tela de Login ?", "Aviso", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                this.Hide();
                JanelaInicial janela = new JanelaInicial();
                janela.ShowDialog();
                e.Cancel = false;
            }
            else if (confirm == DialogResult.No)
                e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BDMedico conexaoMedico = new BDMedico();
            //dataGridView1.DataSource = conexaoMedico.retornarListaMedicos();
        
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                BDMedico bd = new BDMedico();
                List<Medico> listaMedicos = new List<Medico>();
                listaMedicos = bd.retornarListaMedicos();
            Console.WriteLine(listaMedicos[0].Id);
            }
            catch (Exception j)
            {
                Console.WriteLine(j);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
