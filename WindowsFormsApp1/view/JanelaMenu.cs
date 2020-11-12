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

namespace WindowsFormsApp1
{
    public partial class JanelaMenu : Form
    {
        private Usuario usuario;

        private Medico medicoSelecionado;

        public JanelaMenu(string login, string senha)
        {
            usuario = new Usuario();
            usuario.Login = login;
            usuario.Senha = senha;
            InitializeComponent();

            //TIRAR BORDA DE DEIXAR TELA CHEIA
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            this.CenterToScreen();
            
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
            MenuMedico menuMedico = new MenuMedico();
            menuMedico.ShowDialog();
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

                listView1.Items.Clear();
                 listView1.Refresh();

                foreach (Medico m in listaMedicos){

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

                Console.WriteLine(monthCalendar1.SelectionRange.Start.ToShortDateString());
               
            }
            catch (Exception j)
            {
                Console.WriteLine(j);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            
            Console.WriteLine(listView1.SelectedItems[0].Text);
        }

        
    }
}
