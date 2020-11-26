using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Banco_de_Dados;
using WindowsFormsApp1.objetos;
using WindowsFormsApp1.view.Usuario;

namespace WindowsFormsApp1
{
    

    public partial class CadastrarUsuario : Form
    {
        public CadastrarUsuario()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.BringToFront();
            this.Focus();
            //this.ControlBox = false;
            //this.Text = String.Empty;
        }

        private void somenteNumero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cadastrarUsuario()
        {
            try
            {
                Usuario usuario = new Usuario();
                usuario.Funcao = comboFuncao.Text;
                usuario.Login = campoLogin.Text;
                usuario.Senha = campoSenha.Text;
                usuario.DicaSenha = campoDicaSenha.Text;
                usuario.EmailRecuperacao = campoEmail.Text;
                usuario.Nome = campoNome.Text;

                BDUsuario bdUsuario = new BDUsuario();
                bdUsuario.cadastrarUsuario(usuario);

                MessageBox.Show("Cadastrado com Sucesso !");
               
            }
            catch
            {
                ///DEU MERDA NA HORA DE CADASTRAR O MEDICO!!!
            }
        }
        private void limparDados()
        {           
            campoNome.Clear();
            campoLogin.Clear();
            campoSenha.Clear();
            campoDicaSenha.Clear();
            campoEmail.Clear();
            
        }
        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarUsuario();


            if (MessageBox.Show("Deseja Cadastrar outro médico?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                limparDados();
            else
                this.Close();

        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Tem certeza que deseja Cancelar ?", "Aviso", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
                this.Close();
            //else if (confirm == DialogResult.No)
            //    e.Cancel = true;
        }

        private void comboFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void campoNConselho_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void comboConselho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void campoFormacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void campoTelefone1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void campoTelefone2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void campoNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void campoRua_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void campoNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void campoCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void campoRG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void campoIdade_Click(object sender, EventArgs e)
        {

        }

        private void campoBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void campoComplemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioBotaoFeminino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }
    }
}
