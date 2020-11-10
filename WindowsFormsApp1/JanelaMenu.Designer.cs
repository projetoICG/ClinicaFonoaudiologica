namespace WindowsFormsApp1
{
    partial class JanelaMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarConsultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarDadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirMédicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarDadosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.teste = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aaToolStripMenuItem,
            this.testeToolStripMenuItem,
            this.pacienteToolStripMenuItem1,
            this.médicoToolStripMenuItem1,
            this.funcionárioToolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(920, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aaToolStripMenuItem
            // 
            this.aaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacienteToolStripMenuItem,
            this.funcionárioToolStripMenuItem,
            this.médicoToolStripMenuItem});
            this.aaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aaToolStripMenuItem.Name = "aaToolStripMenuItem";
            this.aaToolStripMenuItem.Size = new System.Drawing.Size(128, 36);
            this.aaToolStripMenuItem.Text = "Cadastrar";
            this.aaToolStripMenuItem.Click += new System.EventHandler(this.aaToolStripMenuItem_Click);
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(229, 36);
            this.pacienteToolStripMenuItem.Text = "Paciente";
            this.pacienteToolStripMenuItem.Click += new System.EventHandler(this.pacienteToolStripMenuItem_Click);
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(229, 36);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            // 
            // médicoToolStripMenuItem
            // 
            this.médicoToolStripMenuItem.Name = "médicoToolStripMenuItem";
            this.médicoToolStripMenuItem.Size = new System.Drawing.Size(229, 36);
            this.médicoToolStripMenuItem.Text = "Médico";
            this.médicoToolStripMenuItem.Click += new System.EventHandler(this.médicoToolStripMenuItem_Click);
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaConsultaToolStripMenuItem,
            this.cancelarConsultaToolStripMenuItem,
            this.cancelarConsultaToolStripMenuItem1});
            this.testeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(122, 36);
            this.testeToolStripMenuItem.Text = "Consulta";
            // 
            // novaConsultaToolStripMenuItem
            // 
            this.novaConsultaToolStripMenuItem.Name = "novaConsultaToolStripMenuItem";
            this.novaConsultaToolStripMenuItem.Size = new System.Drawing.Size(318, 36);
            this.novaConsultaToolStripMenuItem.Text = "Nova Consulta";
            // 
            // cancelarConsultaToolStripMenuItem
            // 
            this.cancelarConsultaToolStripMenuItem.Name = "cancelarConsultaToolStripMenuItem";
            this.cancelarConsultaToolStripMenuItem.Size = new System.Drawing.Size(318, 36);
            this.cancelarConsultaToolStripMenuItem.Text = "Reagender Consulta";
            this.cancelarConsultaToolStripMenuItem.Click += new System.EventHandler(this.cancelarConsultaToolStripMenuItem_Click);
            // 
            // cancelarConsultaToolStripMenuItem1
            // 
            this.cancelarConsultaToolStripMenuItem1.Name = "cancelarConsultaToolStripMenuItem1";
            this.cancelarConsultaToolStripMenuItem1.Size = new System.Drawing.Size(318, 36);
            this.cancelarConsultaToolStripMenuItem1.Text = "Cancelar Consulta";
            // 
            // pacienteToolStripMenuItem1
            // 
            this.pacienteToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarDadosToolStripMenuItem,
            this.excluirPacienteToolStripMenuItem});
            this.pacienteToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacienteToolStripMenuItem1.Name = "pacienteToolStripMenuItem1";
            this.pacienteToolStripMenuItem1.Size = new System.Drawing.Size(118, 36);
            this.pacienteToolStripMenuItem1.Text = "Paciente";
            // 
            // alterarDadosToolStripMenuItem
            // 
            this.alterarDadosToolStripMenuItem.Name = "alterarDadosToolStripMenuItem";
            this.alterarDadosToolStripMenuItem.Size = new System.Drawing.Size(268, 36);
            this.alterarDadosToolStripMenuItem.Text = "Alterar Dados";
            // 
            // excluirPacienteToolStripMenuItem
            // 
            this.excluirPacienteToolStripMenuItem.Name = "excluirPacienteToolStripMenuItem";
            this.excluirPacienteToolStripMenuItem.Size = new System.Drawing.Size(268, 36);
            this.excluirPacienteToolStripMenuItem.Text = "Excluir Paciente";
            // 
            // médicoToolStripMenuItem1
            // 
            this.médicoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarDadosToolStripMenuItem1,
            this.excluirMédicoToolStripMenuItem});
            this.médicoToolStripMenuItem1.Name = "médicoToolStripMenuItem1";
            this.médicoToolStripMenuItem1.Size = new System.Drawing.Size(109, 36);
            this.médicoToolStripMenuItem1.Text = "Médico";
            // 
            // alterarDadosToolStripMenuItem1
            // 
            this.alterarDadosToolStripMenuItem1.Name = "alterarDadosToolStripMenuItem1";
            this.alterarDadosToolStripMenuItem1.Size = new System.Drawing.Size(259, 36);
            this.alterarDadosToolStripMenuItem1.Text = "Alterar Dados";
            // 
            // excluirMédicoToolStripMenuItem
            // 
            this.excluirMédicoToolStripMenuItem.Name = "excluirMédicoToolStripMenuItem";
            this.excluirMédicoToolStripMenuItem.Size = new System.Drawing.Size(259, 36);
            this.excluirMédicoToolStripMenuItem.Text = "Excluir Médico";
            // 
            // funcionárioToolStripMenuItem1
            // 
            this.funcionárioToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarDadosToolStripMenuItem2,
            this.excluirFuncionárioToolStripMenuItem});
            this.funcionárioToolStripMenuItem1.Name = "funcionárioToolStripMenuItem1";
            this.funcionárioToolStripMenuItem1.Size = new System.Drawing.Size(154, 36);
            this.funcionárioToolStripMenuItem1.Text = "Funcionário";
            // 
            // alterarDadosToolStripMenuItem2
            // 
            this.alterarDadosToolStripMenuItem2.Name = "alterarDadosToolStripMenuItem2";
            this.alterarDadosToolStripMenuItem2.Size = new System.Drawing.Size(304, 36);
            this.alterarDadosToolStripMenuItem2.Text = "Alterar Dados";
            // 
            // excluirFuncionárioToolStripMenuItem
            // 
            this.excluirFuncionárioToolStripMenuItem.Name = "excluirFuncionárioToolStripMenuItem";
            this.excluirFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(304, 36);
            this.excluirFuncionárioToolStripMenuItem.Text = "Excluir Funcionário";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(68, 36);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.teste);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 540);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(629, 370);
            this.dataGridView1.TabIndex = 0;
            // 
            // teste
            // 
            this.teste.Location = new System.Drawing.Point(743, 263);
            this.teste.Name = "teste";
            this.teste.Size = new System.Drawing.Size(100, 20);
            this.teste.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(757, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // JanelaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 575);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "JanelaMenu";
            this.Text = "Janela2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JanelaMenu_FormClosing_1);
            this.Load += new System.EventHandler(this.Janela2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarConsultaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alterarDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alterarDadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excluirMédicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alterarDadosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem excluirFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox teste;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}