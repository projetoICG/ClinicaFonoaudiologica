using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Banco_de_Dados;
using WindowsFormsApp1.objetos;
using WindowsFormsApp1.view.Medico;
using WindowsFormsApp1.view.Paciente;

namespace WindowsFormsApp1
{
    public partial class JanelaMenu : Form
    {
        private Usuario usuario;

        private Medico medicoSelecionado;

        public JanelaMenu(Usuario user)
        {
            usuario = new Usuario();
            InitializeComponent();
            //TIRAR BORDA DE DEIXAR TELA CHEIA
            //FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            this.CenterToScreen();

            this.usuario = user;
            
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
            MenuPaciente menupaciente = new MenuPaciente();
            menupaciente.Show();
        }

        private void médicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuMedico menuMedico = new MenuMedico();
            menuMedico.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
             
        }

        //private void JanelaMenu_FormClosing_1(object sender, FormClosingEventArgs e)
        //{
        //    DialogResult confirm = MessageBox.Show("Tem certeza que deseja voltar a tela de Login ?", "Aviso", MessageBoxButtons.YesNo);

        //    if (confirm == DialogResult.Yes)
        //    {
        //        this.Hide();
        //        JanelaInicial janela = new JanelaInicial();
        //        janela.ShowDialog();
        //        e.Cancel = false;
        //    }
        //    else if (confirm == DialogResult.No)
        //        e.Cancel = true;
        //}

        



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaConsultas.SelectedItems.Count == 0)
                return;
            
            Console.WriteLine(listaConsultas.SelectedItems[0].Text);
        }

  
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Tem certeza que deseja voltar a tela de Login ?", "Aviso", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                this.Hide();
                JanelaInicial janela = new JanelaInicial();
                janela.ShowDialog();
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuMedico menuMedico = new MenuMedico();
            menuMedico.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToShortDateString() + "\n" + DateTime.Now.ToLongTimeString();
            labelData.Text = time;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelData_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPaciente menupaciente = new MenuPaciente();
            menupaciente.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
