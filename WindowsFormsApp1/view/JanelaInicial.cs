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
using WindowsFormsApp1.Banco_de_Dados;

namespace WindowsFormsApp1
{
    public partial class JanelaInicial : Form
    {
        private Usuario usuario;
        private BDUsuario bdusuario;
        public JanelaInicial()
        {
            InitializeComponent();
            
            this.CenterToScreen();

            usuario = new Usuario();
            bdusuario = new BDUsuario();
        }

        private void timer1_Tick(object sender, EventArgs e) 
        { 
            string time = DateTime.Now.ToLongDateString()+"\n"+DateTime.Now.ToLongTimeString();
            label1.Text = time;
        }

        private void botaoLogin_Click(object sender, EventArgs e)
        {
            usuario = bdusuario.procurarUsuario(campoLogin.Text, campoSenha.Text);
            if (usuario.Login != null)
            {
                JanelaMenu janela2 = new JanelaMenu(usuario);
                this.Hide();
                janela2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario não encontrado!");
            }
        }

        private void JanelaInicial_Load(object sender, EventArgs e)
        {
            //Não deixar usuário redimencionar.
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
        }

    
    }
}
