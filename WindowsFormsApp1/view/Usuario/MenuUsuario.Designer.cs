namespace WindowsFormsApp1.view.Usuario
{
    partial class MenuUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUsuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboFuncao = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.campoNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.campoDicaDaSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.campoSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.campoLogin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.botaoConfirmarAlteracoes = new System.Windows.Forms.Button();
            this.botaoExcluir = new System.Windows.Forms.Button();
            this.botaoAlterar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.campoPesquisar = new System.Windows.Forms.TextBox();
            this.comboPesquisar = new System.Windows.Forms.ComboBox();
            this.botaoPesquisar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.comboFuncao);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.campoNome);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.campoEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.campoDicaDaSenha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.campoSenha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.campoLogin);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 317);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificações";
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboFuncao
            // 
            this.comboFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFuncao.FormattingEnabled = true;
            this.comboFuncao.Items.AddRange(new object[] {
            "Administrador",
            "Funcionario",
            "Medico"});
            this.comboFuncao.Location = new System.Drawing.Point(169, 255);
            this.comboFuncao.Name = "comboFuncao";
            this.comboFuncao.Size = new System.Drawing.Size(233, 21);
            this.comboFuncao.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label6.Location = new System.Drawing.Point(62, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 85;
            this.label6.Text = "Função:";
            // 
            // campoNome
            // 
            this.campoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.campoNome.Location = new System.Drawing.Point(169, 89);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(233, 23);
            this.campoNome.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.Location = new System.Drawing.Point(61, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 83;
            this.label5.Text = "Nome:";
            // 
            // campoEmail
            // 
            this.campoEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.campoEmail.Location = new System.Drawing.Point(168, 218);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(234, 23);
            this.campoEmail.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(61, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 81;
            this.label4.Text = "Email:";
            // 
            // campoDicaDaSenha
            // 
            this.campoDicaDaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.campoDicaDaSenha.Location = new System.Drawing.Point(168, 186);
            this.campoDicaDaSenha.Name = "campoDicaDaSenha";
            this.campoDicaDaSenha.Size = new System.Drawing.Size(234, 23);
            this.campoDicaDaSenha.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(61, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 79;
            this.label3.Text = "Dica da Senha:";
            // 
            // campoSenha
            // 
            this.campoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.campoSenha.Location = new System.Drawing.Point(168, 154);
            this.campoSenha.Name = "campoSenha";
            this.campoSenha.PasswordChar = '*';
            this.campoSenha.Size = new System.Drawing.Size(233, 23);
            this.campoSenha.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(61, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 77;
            this.label2.Text = "Senha:";
            // 
            // campoLogin
            // 
            this.campoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.campoLogin.Location = new System.Drawing.Point(168, 122);
            this.campoLogin.Name = "campoLogin";
            this.campoLogin.Size = new System.Drawing.Size(233, 23);
            this.campoLogin.TabIndex = 76;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label8.Location = new System.Drawing.Point(60, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 75;
            this.label8.Text = "Login:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-46, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 62;
            this.label7.Text = "Cpf:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(-56, 286);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 17);
            this.label14.TabIndex = 74;
            this.label14.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecionar na tabela ao lado";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(475, 118);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(674, 342);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Função";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Senha";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Email";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Dica Senha";
            this.columnHeader6.Width = 154;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.botaoConfirmarAlteracoes);
            this.groupBox2.Controls.Add(this.botaoExcluir);
            this.groupBox2.Controls.Add(this.botaoAlterar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.groupBox2.Location = new System.Drawing.Point(2, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 131);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operações";
            this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox2_Paint);
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // botaoConfirmarAlteracoes
            // 
            this.botaoConfirmarAlteracoes.Location = new System.Drawing.Point(6, 88);
            this.botaoConfirmarAlteracoes.Name = "botaoConfirmarAlteracoes";
            this.botaoConfirmarAlteracoes.Size = new System.Drawing.Size(229, 38);
            this.botaoConfirmarAlteracoes.TabIndex = 3;
            this.botaoConfirmarAlteracoes.Text = "Confirmar Alterações";
            this.botaoConfirmarAlteracoes.UseVisualStyleBackColor = true;
            this.botaoConfirmarAlteracoes.Click += new System.EventHandler(this.botaoConfirmarAlteracoes_Click);
            // 
            // botaoExcluir
            // 
            this.botaoExcluir.Location = new System.Drawing.Point(238, 88);
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(223, 38);
            this.botaoExcluir.TabIndex = 2;
            this.botaoExcluir.Text = "Excluir";
            this.botaoExcluir.UseVisualStyleBackColor = true;
            this.botaoExcluir.Click += new System.EventHandler(this.button3_Click);
            // 
            // botaoAlterar
            // 
            this.botaoAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.botaoAlterar.Location = new System.Drawing.Point(6, 44);
            this.botaoAlterar.Name = "botaoAlterar";
            this.botaoAlterar.Size = new System.Drawing.Size(229, 38);
            this.botaoAlterar.TabIndex = 1;
            this.botaoAlterar.Text = "Alterar";
            this.botaoAlterar.UseVisualStyleBackColor = true;
            this.botaoAlterar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Inserir novo Funcionário";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.campoPesquisar);
            this.panel1.Controls.Add(this.comboPesquisar);
            this.panel1.Controls.Add(this.botaoPesquisar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(475, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 91);
            this.panel1.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(311, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 13);
            this.label19.TabIndex = 110;
            this.label19.Text = "Pesquisar por:";
            // 
            // campoPesquisar
            // 
            this.campoPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoPesquisar.Location = new System.Drawing.Point(247, 55);
            this.campoPesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.campoPesquisar.Name = "campoPesquisar";
            this.campoPesquisar.Size = new System.Drawing.Size(248, 23);
            this.campoPesquisar.TabIndex = 109;
            // 
            // comboPesquisar
            // 
            this.comboPesquisar.FormattingEnabled = true;
            this.comboPesquisar.Items.AddRange(new object[] {
            "Nome",
            "Função"});
            this.comboPesquisar.Location = new System.Drawing.Point(391, 16);
            this.comboPesquisar.Name = "comboPesquisar";
            this.comboPesquisar.Size = new System.Drawing.Size(206, 21);
            this.comboPesquisar.TabIndex = 4;
            this.comboPesquisar.Text = "Nome";
            // 
            // botaoPesquisar
            // 
            this.botaoPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("botaoPesquisar.Image")));
            this.botaoPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoPesquisar.Location = new System.Drawing.Point(500, 50);
            this.botaoPesquisar.Name = "botaoPesquisar";
            this.botaoPesquisar.Size = new System.Drawing.Size(164, 34);
            this.botaoPesquisar.TabIndex = 3;
            this.botaoPesquisar.Text = "Pesquisar";
            this.botaoPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoPesquisar.UseVisualStyleBackColor = true;
            this.botaoPesquisar.Click += new System.EventHandler(this.botaoPesquisar_Click);
            // 
            // MenuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1155, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuUsuario";
            this.Text = "MenuUsuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button botaoAlterar;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button botaoConfirmarAlteracoes;
        private System.Windows.Forms.Button botaoExcluir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botaoPesquisar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox campoPesquisar;
        private System.Windows.Forms.ComboBox comboPesquisar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox campoDicaDaSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox campoSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox campoLogin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboFuncao;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}