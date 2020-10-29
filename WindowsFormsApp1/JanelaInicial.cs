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
using MySql.Data.MySqlClient;


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
            //Vitor Carlos
            this.Hide();
            JanelaMenu janela2 = new JanelaMenu();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objetoConexao = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bdteste;password=123456");
                objetoConexao.Open(); //abrir banco
                MessageBox.Show("banco funcionando");
                objetoConexao.Close(); //sempre fechar conexao
             }
            catch
            {
                MessageBox.Show("deu merda no banco");
            }
        }
    }
}
