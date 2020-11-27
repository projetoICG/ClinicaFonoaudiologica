using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using WindowsFormsApp1.Banco_de_Dados;
using WindowsFormsApp1.objetos;
using WindowsFormsApp1;


namespace WindowsFormsApp1.view.Usuario
{
    public partial class MenuUsuario : Form
    {
        List<WindowsFormsApp1.objetos.Usuario> listaUsuariosNoBanco;
        WindowsFormsApp1.objetos.Usuario usuarioSelecionado;
        BDUsuario bdUsuario;
        public MenuUsuario()
        {
            InitializeComponent();
            botaoConfirmarAlteracoes.Enabled = false;
            botaoExcluir.Enabled = false;
            botaoAlterar.Enabled = false;
            listaUsuariosNoBanco = new List<WindowsFormsApp1.objetos.Usuario>();
            alterarEstadoCampos(false);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            bdUsuario = new BDUsuario();
            listaUsuariosNoBanco = bdUsuario.retornarListaUsuarios();
            atualizarLista(listaUsuariosNoBanco);
            this.CenterToScreen();
        }

        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Red, Color.Black);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void campoIdade_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarUsuario cadastrarusuario = new CadastrarUsuario();

            cadastrarusuario.ShowDialog();
            atualizarLista(listaUsuariosNoBanco = bdUsuario.retornarListaUsuarios());
        }
        private void atualizarLista(List<WindowsFormsApp1.objetos.Usuario> listaUsuarios)
        {

            try
            {

                listView1.Items.Clear();
                listView1.Refresh();

                foreach (WindowsFormsApp1.objetos.Usuario m in listaUsuarios)
                {

                    ListViewItem varItem = new ListViewItem(new string[]
                    {
                        Convert.ToString(m.Id),
                        m.Nome,
                        m.Funcao,
                        m.Senha,
                        m.EmailRecuperacao,
                        m.DicaSenha
                    });
                    listView1.Items.Add(varItem);
                }

            }
            catch (Exception j)
            {
                Console.WriteLine(j);
            }
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Red, Color.Black);
        }

        private void alterarEstadoCampos(bool estado)
        {
            campoNome.Enabled = estado;
            campoDicaDaSenha.Enabled = estado;
            campoEmail.Enabled = estado;
            campoLogin.Enabled = estado;
            campoSenha.Enabled = estado;
            comboFuncao.Enabled = estado;
        }

        private void mostrarDadosNoPainel(int ID)
        {


            foreach (WindowsFormsApp1.objetos.Usuario m in listaUsuariosNoBanco)
            {
                if (ID == m.Id)
                {
                    campoNome.Text = m.Nome;
                    campoDicaDaSenha.Text = m.DicaSenha;
                    campoEmail.Text = m.EmailRecuperacao;
                    campoLogin.Text = m.Login;
                    campoSenha.Text = m.Senha;
                    comboFuncao.Text = m.Funcao;
                }
            }
        }



        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            botaoConfirmarAlteracoes.Enabled = false;
            

            alterarEstadoCampos(false);
            if (listView1.SelectedItems.Count == 0)
                return;

            mostrarDadosNoPainel(Convert.ToInt32(listView1.SelectedItems[0].Text));
            botaoAlterar.Enabled = true;
            botaoExcluir.Enabled = true;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var teste = listView1.SelectedItems[0].Text;
                alterarEstadoCampos(true);
                botaoConfirmarAlteracoes.Enabled = true;
                botaoExcluir.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Por favor Selecione na tabela !");
            }
        }

        private void limparCampos()
        {
            campoNome.Clear();
            campoDicaDaSenha.Clear();
            campoEmail.Clear();
            campoLogin.Clear();
            campoSenha.Clear();
            comboFuncao.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Tem certeza que deseja Excluir ?", "Aviso !", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {

                try
                {
                    bdUsuario.excluirUsuario(Convert.ToInt32(listView1.SelectedItems[0].Text));
                    MessageBox.Show("Excluido com sucesso!");
                    botaoConfirmarAlteracoes.Enabled = false;
                    botaoExcluir.Enabled = false;
                    atualizarLista(listaUsuariosNoBanco = bdUsuario.retornarListaUsuarios());
                    alterarEstadoCampos(false);
                    limparCampos();
                }
                catch
                {

                }
            }

        }

        private void botaoConfirmarAlteracoes_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Tem certeza que deseja confirmar as mudanças?", "Aviso !", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {

                try
                {
                    BDUsuario bdusuario = new BDUsuario();

                    WindowsFormsApp1.objetos.Usuario usuarioAlterado = usuarioSelecionado;

                    //vou mudar tudo menos o id que é padrão.
                    usuarioAlterado.Nome = campoNome.Text;
                    usuarioAlterado.DicaSenha = campoDicaDaSenha.Text;
                    usuarioAlterado.EmailRecuperacao = campoEmail.Text;
                    usuarioAlterado.Funcao = comboFuncao.Text;
                    usuarioAlterado.Login = campoLogin.Text;
                    usuarioAlterado.Senha = campoSenha.Text;

                    bdusuario.atualizarUsuario(usuarioAlterado);
                    MessageBox.Show("Atualizado com sucesso!");
                    atualizarLista(listaUsuariosNoBanco = bdUsuario.retornarListaUsuarios());

                }
                catch
                {

                }
            }

        }

        private void campoNConselho_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoPesquisar_Click(object sender, EventArgs e)
        {
            if (campoPesquisar.Text != "")
            {
                List<WindowsFormsApp1.objetos.Usuario> usuarios = new List<WindowsFormsApp1.objetos.Usuario>();
                if ((usuarios = bdUsuario.buscarEspecificacaoUsuario(comboPesquisar.Text, campoPesquisar.Text)) != null)
                {
                    atualizarLista(usuarios);
                }
            }
            else
            {
                atualizarLista(listaUsuariosNoBanco);
            }
        }

    }
}