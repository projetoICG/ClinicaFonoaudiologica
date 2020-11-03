namespace WindowsFormsApp1
{
    partial class CadastroUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.campoLogin = new System.Windows.Forms.TextBox();
            this.campoSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.campoDicaDaSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.botaoCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.Location = new System.Drawing.Point(90, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login:";
            // 
            // campoLogin
            // 
            this.campoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.campoLogin.Location = new System.Drawing.Point(234, 29);
            this.campoLogin.Name = "campoLogin";
            this.campoLogin.Size = new System.Drawing.Size(168, 27);
            this.campoLogin.TabIndex = 2;
            // 
            // campoSenha
            // 
            this.campoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.campoSenha.Location = new System.Drawing.Point(234, 79);
            this.campoSenha.Name = "campoSenha";
            this.campoSenha.PasswordChar = '*';
            this.campoSenha.Size = new System.Drawing.Size(168, 27);
            this.campoSenha.TabIndex = 4;
            this.campoSenha.TextChanged += new System.EventHandler(this.campoSenha_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(90, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // campoDicaDaSenha
            // 
            this.campoDicaDaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.campoDicaDaSenha.Location = new System.Drawing.Point(234, 128);
            this.campoDicaDaSenha.Name = "campoDicaDaSenha";
            this.campoDicaDaSenha.Size = new System.Drawing.Size(217, 27);
            this.campoDicaDaSenha.TabIndex = 6;
            this.campoDicaDaSenha.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(90, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dica da Senha:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // campoEmail
            // 
            this.campoEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.campoEmail.Location = new System.Drawing.Point(234, 177);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(217, 27);
            this.campoEmail.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(90, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email:";
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.botaoCancelar.Location = new System.Drawing.Point(94, 253);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(95, 45);
            this.botaoCancelar.TabIndex = 10;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            // 
            // botaoCadastrar
            // 
            this.botaoCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.botaoCadastrar.Location = new System.Drawing.Point(356, 253);
            this.botaoCadastrar.Name = "botaoCadastrar";
            this.botaoCadastrar.Size = new System.Drawing.Size(95, 45);
            this.botaoCadastrar.TabIndex = 11;
            this.botaoCadastrar.Text = "Cadastrar";
            this.botaoCadastrar.UseVisualStyleBackColor = true;
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 310);
            this.Controls.Add(this.botaoCadastrar);
            this.Controls.Add(this.botaoCancelar);
            this.Controls.Add(this.campoEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.campoDicaDaSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.campoSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.campoLogin);
            this.Controls.Add(this.label1);
            this.Name = "CadastroUsuario";
            this.Text = "CadastroUsuario";
            this.Load += new System.EventHandler(this.CadastroUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox campoLogin;
        private System.Windows.Forms.TextBox campoSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox campoDicaDaSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botaoCancelar;
        private System.Windows.Forms.Button botaoCadastrar;
    }
}