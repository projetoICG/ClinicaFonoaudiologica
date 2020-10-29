using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            JanelaInicial janela = new JanelaInicial();
            janela.Show();
            this.Close();
        }

        private void Janela2_Load(object sender, EventArgs e)
        {

        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cancelarConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            JanelaInicial janela = new JanelaInicial();
            janela.ShowDialog();
            //caralho
            this.Close();
        }

        private void funcionárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void maiorDeIdadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarPaciente cadastrarpaciente = new CadastrarPaciente();
            cadastrarpaciente.Show();
        }
    }
}
