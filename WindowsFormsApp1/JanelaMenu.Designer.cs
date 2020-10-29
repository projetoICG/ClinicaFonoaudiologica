﻿namespace WindowsFormsApp1
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
            this.maiorDeIdadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menorDeIdadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1227, 40);
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
            this.pacienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maiorDeIdadeToolStripMenuItem,
            this.menorDeIdadeToolStripMenuItem});
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(229, 36);
            this.pacienteToolStripMenuItem.Text = "Paciente";
            // 
            // maiorDeIdadeToolStripMenuItem
            // 
            this.maiorDeIdadeToolStripMenuItem.Name = "maiorDeIdadeToolStripMenuItem";
            this.maiorDeIdadeToolStripMenuItem.Size = new System.Drawing.Size(275, 36);
            this.maiorDeIdadeToolStripMenuItem.Text = "Maior de Idade";
            this.maiorDeIdadeToolStripMenuItem.Click += new System.EventHandler(this.maiorDeIdadeToolStripMenuItem_Click);
            // 
            // menorDeIdadeToolStripMenuItem
            // 
            this.menorDeIdadeToolStripMenuItem.Name = "menorDeIdadeToolStripMenuItem";
            this.menorDeIdadeToolStripMenuItem.Size = new System.Drawing.Size(275, 36);
            this.menorDeIdadeToolStripMenuItem.Text = "Menor de Idade";
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
            this.funcionárioToolStripMenuItem1.Click += new System.EventHandler(this.funcionárioToolStripMenuItem1_Click);
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
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1227, 664);
            this.panel1.TabIndex = 1;
            // 
            // Janela2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 708);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Janela2";
            this.Text = "Janela2";
            this.Load += new System.EventHandler(this.Janela2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maiorDeIdadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menorDeIdadeToolStripMenuItem;
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
    }
}