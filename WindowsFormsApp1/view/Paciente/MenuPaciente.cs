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


namespace WindowsFormsApp1.view.Paciente
{
    public partial class MenuPaciente : Form
    {
        List<WindowsFormsApp1.objetos.Paciente> listaPacientesNoBanco;
        BDPaciente bdPaciente;
        WindowsFormsApp1.objetos.Paciente pacienteSelecionado;
        public MenuPaciente()
        {
            InitializeComponent();
            botaoConfirmarAlteracoes.Enabled = false;
            botaoExcluir.Enabled = false;
            botaoAlterar.Enabled = false;
            listaPacientesNoBanco = new List<WindowsFormsApp1.objetos.Paciente>();
            alterarEstadoCampos(false);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            bdPaciente = new BDPaciente();
            atualizarLista(listaPacientesNoBanco = bdPaciente.retornarListaPacientes());
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

        private void campoDataNascimento_Click(object sender, EventArgs e)
        {
            int startPos = this.campoDataNascimento.MaskedTextProvider.FindUnassignedEditPositionFrom(this.campoDataNascimento.MaskedTextProvider.LastAssignedPosition + 1, true);
            this.campoDataNascimento.Select(startPos, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarPaciente cadastrarpaciente = new CadastrarPaciente();
            
            cadastrarpaciente.ShowDialog();
            atualizarLista(listaPacientesNoBanco = bdPaciente.retornarListaPacientes());
        }
        private void atualizarLista(List<WindowsFormsApp1.objetos.Paciente> listaPacientes)
        {
            try
            {
                listView1.Items.Clear();
                listView1.Refresh();
                
                foreach (objetos.Paciente m in listaPacientes)
                {

                    ListViewItem varItem = new ListViewItem(new string[]
                    {
                        Convert.ToString(m.Id),
                        m.Nome,
                        m.Cpf,
                        m.Email,
                        m.Telefone1,
                        m.Telefone2,
                        m.Rg
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
            campoCPF.Enabled = estado;
            campoRG.Enabled = estado;
            campoRua.Enabled = estado;
            campoBairro.Enabled = estado;
            campoComplemento.Enabled = estado;
            campoNumero.Enabled = estado;
            campoDataNascimento.Enabled = estado;
            campoEmail.Enabled = estado;
            campoObservacao.Enabled = estado;
            campoTelefone1.Enabled = estado;
            campoTelefone2.Enabled = estado;
            radioBotaoFeminino.Enabled = estado;
            radioBotaoMasculino.Enabled = estado;
        }
        private void limparCampos()
        {
            campoNome.Clear();
            campoCPF.Clear();
            campoRG.Clear();
            campoRua.Clear();
            campoBairro.Clear();
            campoComplemento.Clear();
            campoNumero.Clear();
            campoDataNascimento.Clear();
            campoEmail.Clear();
            campoTelefone1.Clear();
            campoTelefone2.Clear();
            radioBotaoFeminino.Checked = false;
            radioBotaoMasculino.Checked = false;
            campoObservacao.Clear();
        }
        private void mostrarDadosNoPainel(int ID)
        {


            foreach (WindowsFormsApp1.objetos.Paciente m in listaPacientesNoBanco)
            {
                if (ID == m.Id)
                {
                    campoNome.Text = m.Nome;
                    campoCPF.Text = m.Cpf;
                    campoRG.Text = m.Rg;
                    campoRua.Text = m.Rua;
                    campoBairro.Text = m.Bairro;
                    campoComplemento.Text = m.Complemento;
                    campoNumero.Text = m.Numero;
                    campoDataNascimento.Text = m.DataNascimento;
                    campoEmail.Text = m.Email;
                    campoTelefone1.Text = m.Telefone1;
                    campoTelefone2.Text = m.Telefone2;
                    if (m.Sexo == 'M')
                        radioBotaoMasculino.Checked = true;
                    else
                        radioBotaoFeminino.Checked = true;
                    campoObservacao.Text = m.Observacoes;

                    pacienteSelecionado = m;
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
        /*
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
        */
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Tem certeza que deseja Excluir ?", "Aviso !", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {

                try
                {
                    bdPaciente.excluirPaciente(Convert.ToInt32(listView1.SelectedItems[0].Text));
                    MessageBox.Show("Excluido com sucesso!");
                    botaoConfirmarAlteracoes.Enabled = false;
                    botaoExcluir.Enabled = false;
                    atualizarLista(listaPacientesNoBanco = bdPaciente.retornarListaPacientes());
                    alterarEstadoCampos(false);
                    limparCampos();
                }
                catch
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void botaoConfirmarAlteracoes_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Tem certeza que deseja confirmar as mudanças?", "Aviso !", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {

                try
                {
                    BDMedico bdmedico = new BDMedico();

                    WindowsFormsApp1.objetos.Paciente pacienteAlterado = pacienteSelecionado;

                    //vou mudar tudo menos o id que é padrão.
                    pacienteAlterado.Nome = campoNome.Text;
                    pacienteAlterado.Cpf = campoCPF.Text;
                    pacienteAlterado.Rg = campoRG.Text;
                    pacienteAlterado.Rua = campoRua.Text;
                    pacienteAlterado.Bairro = campoBairro.Text;
                    pacienteAlterado.Complemento = campoComplemento.Text;
                    pacienteAlterado.Numero = campoNumero.Text;
                    pacienteAlterado.DataNascimento = campoDataNascimento.Text;
                    pacienteAlterado.Email = campoEmail.Text;
                    pacienteAlterado.Observacoes = campoObservacao.Text;
                    pacienteAlterado.Telefone1 = campoTelefone1.Text;
                    pacienteAlterado.Telefone2 = campoTelefone2.Text;

                    if (radioBotaoFeminino.Checked)
                        pacienteAlterado.Sexo = 'F';
                    else
                        pacienteAlterado.Sexo = 'M';
                    
                    bdPaciente.atualizarPaciente(pacienteAlterado);

                    MessageBox.Show("Atualizado com sucesso!");
                    atualizarLista(listaPacientesNoBanco = bdPaciente.retornarListaPacientes());

                    limparCampos();
                    botaoExcluir.Enabled = false;
                    alterarEstadoCampos(false);
                }
                catch
                {

                }
            }
        }

        private void botaoPesquisar_Click(object sender, EventArgs e)
        {
            if (campoPesquisar.Text != "")
            {
                List<WindowsFormsApp1.objetos.Paciente> pacientes = new List<WindowsFormsApp1.objetos.Paciente>();
                if ((pacientes = bdPaciente.buscarEspecificacaoPaciente(comboPesquisar.Text, campoPesquisar.Text)) != null)
                {
                    atualizarLista(pacientes);
                }
            }
            else
            {
                atualizarLista(listaPacientesNoBanco);
            }
        }

        private void botaoAlterar_Click(object sender, EventArgs e)
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

        private void MenuPaciente_Load(object sender, EventArgs e)
        {

        }
        /*
private void button3_Click(object sender, EventArgs e)
{
DialogResult confirm = MessageBox.Show("Tem certeza que deseja Excluir ?", "Aviso !", MessageBoxButtons.YesNo);

if (confirm == DialogResult.Yes)
{

try
{
BDPaciente bdpaciente = new BDPaciente();
bdpaciente.excluirPaciente(Convert.ToInt32(listView1.SelectedItems[0].Text));
MessageBox.Show("Excluido com sucesso!");
}
catch
{

}
}
atualizarLista();

}
*/
    }
}
