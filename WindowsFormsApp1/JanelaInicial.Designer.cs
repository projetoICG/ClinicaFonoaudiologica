namespace WindowsFormsApp1
{
    partial class JanelaInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.botaoLogin = new System.Windows.Forms.Button();
            this.botaoRecuperarSenha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.campoLogin = new System.Windows.Forms.TextBox();
            this.campoSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaoLogin
            // 
            this.botaoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoLogin.Location = new System.Drawing.Point(248, 282);
            this.botaoLogin.Name = "botaoLogin";
            this.botaoLogin.Size = new System.Drawing.Size(142, 63);
            this.botaoLogin.TabIndex = 0;
            this.botaoLogin.Text = "Entrar";
            this.botaoLogin.UseVisualStyleBackColor = true;
            this.botaoLogin.Click += new System.EventHandler(this.clicarBotao);
            // 
            // botaoRecuperarSenha
            // 
            this.botaoRecuperarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoRecuperarSenha.Location = new System.Drawing.Point(32, 282);
            this.botaoRecuperarSenha.Name = "botaoRecuperarSenha";
            this.botaoRecuperarSenha.Size = new System.Drawing.Size(157, 63);
            this.botaoRecuperarSenha.TabIndex = 1;
            this.botaoRecuperarSenha.Text = "Recuperar Senha";
            this.botaoRecuperarSenha.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // campoLogin
            // 
            this.campoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoLogin.Location = new System.Drawing.Point(125, 117);
            this.campoLogin.Margin = new System.Windows.Forms.Padding(2);
            this.campoLogin.MaxLength = 39000;
            this.campoLogin.Name = "campoLogin";
            this.campoLogin.Size = new System.Drawing.Size(193, 35);
            this.campoLogin.TabIndex = 3;
            this.campoLogin.TextChanged += new System.EventHandler(this.campoLogin_TextChanged);
            // 
            // campoSenha
            // 
            this.campoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoSenha.Location = new System.Drawing.Point(125, 199);
            this.campoSenha.Margin = new System.Windows.Forms.Padding(2);
            this.campoSenha.MaxLength = 39000;
            this.campoSenha.Name = "campoSenha";
            this.campoSenha.PasswordChar = '*';
            this.campoSenha.Size = new System.Drawing.Size(193, 35);
            this.campoSenha.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha";
            // 
            // JanelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(422, 364);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.campoSenha);
            this.Controls.Add(this.campoLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoRecuperarSenha);
            this.Controls.Add(this.botaoLogin);
            this.MaximizeBox = false;
            this.Name = "JanelaInicial";
            this.Text = "Nome Aplcativo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.interfaceInicio_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoLogin;
        private System.Windows.Forms.Button botaoRecuperarSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox campoLogin;
        private System.Windows.Forms.TextBox campoSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

