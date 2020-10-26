using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.objetos;
namespace WindowsFormsApp1
{
    public partial class JanelaInicial : Form
    {
        public JanelaInicial()
        {
            InitializeComponent();
            
            this.CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void interfaceInicio_KeyUp(object sender, KeyEventArgs e)
        {

        }


        private void clicarBotao(object sender, EventArgs e)
        {
            string login = campoLogin.Text;
            string senha = campoSenha.Text;

            this.Hide();
            Janela2 janela2 = new Janela2();
            janela2.ShowDialog();
            this.Close();

        }

        private void timer1_Tick(object sender, EventArgs e) 
        { 
            string time = DateTime.Now.ToLongTimeString();
            label1.Text = time;
        }

        private void campoLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
