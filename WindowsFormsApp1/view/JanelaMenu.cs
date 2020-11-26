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
using WindowsFormsApp1.view.Consulta;
using WindowsFormsApp1.view.Usuario;

namespace WindowsFormsApp1
{
    public partial class JanelaMenu : Form
    {
        private Usuario usuario;

        List<Consulta> listaConsultas;

        public JanelaMenu(Usuario user)
        {
            usuario = new Usuario();
            InitializeComponent();


            //desabilitando campos de consulta
            alterarEstadoCampos(false);

            listaConsultas = new List<Consulta>();

            //TIRAR BORDA DE DEIXAR TELA CHEIA
            //FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            this.CenterToScreen();

            this.usuario = user;
            
        }

        private void atualizarLista(List<Consulta> listaConsultas)
        {

            try
            {

                listView.Items.Clear();
                listView.Refresh();

                foreach (Consulta m in listaConsultas)
                {

                    ListViewItem varItem = new ListViewItem(new string[]
                    {
                        Convert.ToString(m.IdConsulta),
                        m.NomePaciente,
                        m.NomeMedico,
                        m.Data,
                        m.HoraInicio,
                        m.HoraFim,
                        Convert.ToString(m.ValorConsulta)
                    });
                    listView.Items.Add(varItem);
                }

            }
            catch (Exception j)
            {
                Console.WriteLine(j);
            }
        }

        private void alterarEstadoCampos(bool estado)
        {
            campoHoraFim.Enabled = estado;
            campoHoraInicio.Enabled = estado;
            campoNomePaciente.Enabled = estado;
            campoValorConsulta.Enabled = estado;
            campoNomeMedico.Enabled = estado;
            dateTimePicker3.Enabled = estado;

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
            if (listView.SelectedItems.Count == 0)
                return;
            
            Console.WriteLine(listView.SelectedItems[0].Text);
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


        private void button1_Click(object sender, EventArgs e)
        {
            MenuPaciente menupaciente = new MenuPaciente();
            menupaciente.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToLongDateString() + "\n" + DateTime.Now.ToLongTimeString();
            labelDataEhora.Text = time;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CadastrarConsulta cadastrarconsulta = new CadastrarConsulta();
            cadastrarconsulta.ShowDialog();
        }

        private void botaoAlterarConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                var teste = listView.SelectedItems[0].Text;
                
                botaoAlterarConsulta.Enabled = true;
                botaoExcluirConsulta.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Por favor Selecione na tabela !");
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuUsuario menuUsuario = new MenuUsuario();
            menuUsuario.ShowDialog();
        }

        private void JanelaMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
