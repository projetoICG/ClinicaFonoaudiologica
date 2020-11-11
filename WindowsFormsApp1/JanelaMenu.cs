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
        Usuario usuario;

        public JanelaMenu(string login, string senha)
        {
            InitializeComponent();
            this.CenterToScreen();

            usuario.Login = login;
            usuario.Senha = senha;
            autenticar();
        }

        public bool operacaoConfirmada()
        {
            return true;
        }

        private void autenticar()
        {
            BDUsuario bdusuario= new BDUsuario();
            bdusuario.procurarUsuario(usuario.Login, usuario.Senha);
            if (usuario.Id == null)
            {
                this.Close();
            } else
            {
                Console.WriteLine("Logado");
            }

        }

        /*
        public static bool executar()
        {
            JanelaMenu janela2 = new JanelaMenu();
            janela2.Visible = true;

            return janela2.operacaoConfirmada();
        }
        */
       
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
            BDMedico conexaoMedico = new BDMedico();
            dataGridView1.DataSource = conexaoMedico.retornarListaMedicos();
        }
    }
}
