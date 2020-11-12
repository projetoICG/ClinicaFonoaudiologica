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


namespace WindowsFormsApp1.view.Medico
{
    public partial class MenuMedico : Form
    {
        List<WindowsFormsApp1.objetos.Medico> listaMedicosNoBanco;
        public MenuMedico()
        {
            InitializeComponent();
            listaMedicosNoBanco = new List<WindowsFormsApp1.objetos.Medico>();
            alterarEstadoCampos(false);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            atualizarLista();
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
            CadastrarMedico cadastrarmedico = new CadastrarMedico();
            
            cadastrarmedico.ShowDialog();
            atualizarLista();
        }
        private void atualizarLista()
        {

            try
            {
                BDMedico bd = new BDMedico();
               
                listaMedicosNoBanco = bd.retornarListaMedicos();

                listView1.Items.Clear();
                listView1.Refresh();
                
                foreach (WindowsFormsApp1.objetos.Medico m in listaMedicosNoBanco)
                {

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
            campoNConselho.Enabled = estado;
            campoFormacao.Enabled = estado;
            campoTelefone1.Enabled = estado;
            campoTelefone2.Enabled = estado;
            radioBotaoFeminino.Enabled = estado;
            radioBotaoMasculino.Enabled = estado;
            comboFuncao.Enabled = estado;
            comboConselho.Enabled = estado;
            campoNConselho.Enabled = estado;
        }

        private void mostrarDadosNoPainel(int ID)
        {


            foreach (WindowsFormsApp1.objetos.Medico m in listaMedicosNoBanco)
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
                    campoNConselho.Text = m.Conselho;
                    campoFormacao.Text = m.Formacao;
                    campoTelefone1.Text = m.Telefone1;
                    campoTelefone2.Text = m.Telefone2;
                    if (m.Sexo == 'M')
                        radioBotaoMasculino.Checked = true;
                    else
                        radioBotaoFeminino.Checked = true;
                    comboConselho.Text = m.Conselho;
                    comboFuncao.Text = m.Funcao;
                }
            }
        }



        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            alterarEstadoCampos(false);
            if (listView1.SelectedItems.Count == 0)
                return;

            mostrarDadosNoPainel(Convert.ToInt32(listView1.SelectedItems[0].Text));

        }
    }
}
