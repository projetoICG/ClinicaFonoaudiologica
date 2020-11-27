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
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class JanelaMenu : Form
    {
        private Usuario usuario;


        List<Consulta> listaConsultas;
        BDConsulta bdconsulta;
        Consulta consultaSelecionada;
        public JanelaMenu(Usuario user)
        {
            usuario = new Usuario();
            bdconsulta = new BDConsulta();
            InitializeComponent();


            //desabilitando campos de consulta
            alterarEstadoCampos(false);

            listaConsultas = bdconsulta.retornarListaConsulta();
            atualizarLista(listaConsultas);





            //TIRAR BORDA DE DEIXAR TELA CHEIA
            //FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            this.CenterToScreen();

            this.usuario = user;

            labelNome.Text = usuario.Nome;
            if (usuario.Funcao != "Administrador")
            {
                button3.Enabled = false;
                button2.Enabled = false;
            }
            
            
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
                alterarEstadoCampos(true);
                botaoAlterarConsulta.Enabled = true;
                botaoExcluirConsulta.Enabled = true;
                botaoConfirmarAlteracoesConsulta.Enabled = true;
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
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "dd/MM/yyyy";
            


        }

        private void mostrarDadosNoPainel(int ID)
        {

            foreach (Consulta m in listaConsultas)
            {
                if (ID == m.IdConsulta)
                {
                    campoHoraFim.Text = m.HoraFim;
                    campoHoraInicio.Text = m.HoraInicio;
                    campoNomePaciente.Text = m.NomePaciente;
                    campoValorConsulta.Text = Convert.ToString(m.ValorConsulta);
                    dateTimePicker3.Value = DateTime.ParseExact(m.Data, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);


                    consultaSelecionada = m;
                    
                    //selecionou, vai adicionar o objeto medico selecionado
                    //nessa variavel
                    //medicoSelecionado = m;
                }
            }
        }


        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            botaoConfirmarAlteracoesConsulta.Enabled = false;
            botaoExcluirConsulta.Enabled = false;

            alterarEstadoCampos(false);
            if (listView.SelectedItems.Count == 0)
                return;

            mostrarDadosNoPainel(Convert.ToInt32(listView.SelectedItems[0].Text));
            botaoAlterarConsulta.Enabled = true;
        }

        private void botaoConfirmarAlteracoesConsulta_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Tem certeza que deseja confirmar as mudanças?", "Aviso !", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {

                try
                {
                    BDMedico bdmedico = new BDMedico();

                    Consulta consultaAlterada = consultaSelecionada;

                    //vou mudar tudo menos o id que é padrão.
                    consultaAlterada.NomePaciente = campoNomePaciente.Text;
                    consultaAlterada.Data = dateTimePicker3.Text;
                    consultaAlterada.HoraInicio = campoHoraInicio.Text;
                    consultaAlterada.HoraFim = campoHoraFim.Text;
                    consultaAlterada.ValorConsulta = Convert.ToInt32(campoValorConsulta.Text);

             
                    bdconsulta.atualizarConsulta(consultaAlterada);
                    MessageBox.Show("Atualizado com sucesso!");
                    atualizarLista(listaConsultas  = bdconsulta.retornarListaConsulta());
                    limparCampos();
                    botaoExcluirConsulta.Enabled = false;
                    alterarEstadoCampos(false);
                }
                catch
                {

                }
            }
            botaoConfirmarAlteracoesConsulta.Enabled = false;
        }


        private void limparCampos()
        {
            campoHoraFim.Clear();
            campoHoraInicio.Clear();
            campoNomePaciente.Clear();
            campoValorConsulta.Clear();
            dateTimePicker3.ResetText();
        }

        private void botaoExcluirConsulta_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Tem certeza que deseja Excluir ?", "Aviso !", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {

                try
                {
                    bdconsulta.excluirConsulta(consultaSelecionada.IdConsulta);
                    MessageBox.Show("Excluido com sucesso!");
                    botaoConfirmarAlteracoesConsulta.Enabled = false;
                    botaoExcluirConsulta.Enabled = false;
                    atualizarLista(listaConsultas = bdconsulta.retornarListaConsulta());
                    alterarEstadoCampos(false);
                    limparCampos();
                }
                catch
                {

                }
            }
        }
    }
}
