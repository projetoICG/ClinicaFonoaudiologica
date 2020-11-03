namespace WindowsFormsApp1
{
    partial class CadastrarPaciente
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.campoNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.botaoCadastrar = new System.Windows.Forms.Button();
            this.campoDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.campoCPF = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.campoRua = new System.Windows.Forms.TextBox();
            this.campoIdade = new System.Windows.Forms.Label();
            this.campoBairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.campoNumero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.campoComplemento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.campoTelefone1 = new System.Windows.Forms.TextBox();
            this.campoTelefone2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(354, 66);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(117, 28);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "Masculino";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(229, 66);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(111, 28);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Feminino";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // campoNome
            // 
            this.campoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNome.Location = new System.Drawing.Point(229, 23);
            this.campoNome.Margin = new System.Windows.Forms.Padding(2);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(242, 27);
            this.campoNome.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sexo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data Nascimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(339, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Idade:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 116);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cpf:";
            // 
            // botaoCadastrar
            // 
            this.botaoCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.botaoCadastrar.Location = new System.Drawing.Point(385, 614);
            this.botaoCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.botaoCadastrar.Name = "botaoCadastrar";
            this.botaoCadastrar.Size = new System.Drawing.Size(96, 47);
            this.botaoCadastrar.TabIndex = 14;
            this.botaoCadastrar.Text = "Cadastrar";
            this.botaoCadastrar.UseVisualStyleBackColor = true;
            this.botaoCadastrar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // campoDataNascimento
            // 
            this.campoDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoDataNascimento.Location = new System.Drawing.Point(229, 165);
            this.campoDataNascimento.Margin = new System.Windows.Forms.Padding(2);
            this.campoDataNascimento.Mask = "00/00/0000";
            this.campoDataNascimento.Name = "campoDataNascimento";
            this.campoDataNascimento.Size = new System.Drawing.Size(97, 27);
            this.campoDataNascimento.TabIndex = 15;
            this.campoDataNascimento.ValidatingType = typeof(System.DateTime);
            this.campoDataNascimento.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.campoDataNascimento_TypeValidationCompleted);
            // 
            // campoCPF
            // 
            this.campoCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.campoCPF.Location = new System.Drawing.Point(229, 116);
            this.campoCPF.Margin = new System.Windows.Forms.Padding(2);
            this.campoCPF.Mask = "000.000.000-00";
            this.campoCPF.Name = "campoCPF";
            this.campoCPF.Size = new System.Drawing.Size(134, 27);
            this.campoCPF.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 217);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Rua:";
            // 
            // campoRua
            // 
            this.campoRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoRua.Location = new System.Drawing.Point(229, 217);
            this.campoRua.Margin = new System.Windows.Forms.Padding(2);
            this.campoRua.Name = "campoRua";
            this.campoRua.Size = new System.Drawing.Size(242, 27);
            this.campoRua.TabIndex = 18;
            // 
            // campoIdade
            // 
            this.campoIdade.AutoSize = true;
            this.campoIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoIdade.Location = new System.Drawing.Point(397, 168);
            this.campoIdade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.campoIdade.Name = "campoIdade";
            this.campoIdade.Size = new System.Drawing.Size(59, 20);
            this.campoIdade.TabIndex = 12;
            this.campoIdade.Text = "          ";
            this.campoIdade.Click += new System.EventHandler(this.label6_Click);
            // 
            // campoBairro
            // 
            this.campoBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoBairro.Location = new System.Drawing.Point(229, 264);
            this.campoBairro.Margin = new System.Windows.Forms.Padding(2);
            this.campoBairro.Name = "campoBairro";
            this.campoBairro.Size = new System.Drawing.Size(242, 27);
            this.campoBairro.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(72, 264);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Bairro:";
            // 
            // campoNumero
            // 
            this.campoNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNumero.Location = new System.Drawing.Point(229, 312);
            this.campoNumero.Margin = new System.Windows.Forms.Padding(2);
            this.campoNumero.Name = "campoNumero";
            this.campoNumero.Size = new System.Drawing.Size(53, 27);
            this.campoNumero.TabIndex = 22;
            this.campoNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.somenteNumero);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(72, 312);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Número:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(72, 362);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Complemento:";
            // 
            // campoComplemento
            // 
            this.campoComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoComplemento.Location = new System.Drawing.Point(229, 362);
            this.campoComplemento.Margin = new System.Windows.Forms.Padding(2);
            this.campoComplemento.Name = "campoComplemento";
            this.campoComplemento.Size = new System.Drawing.Size(242, 27);
            this.campoComplemento.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(72, 409);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Telefone 1:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(72, 458);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "Telefone 2:";
            // 
            // campoTelefone1
            // 
            this.campoTelefone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoTelefone1.Location = new System.Drawing.Point(229, 409);
            this.campoTelefone1.Margin = new System.Windows.Forms.Padding(2);
            this.campoTelefone1.Name = "campoTelefone1";
            this.campoTelefone1.Size = new System.Drawing.Size(185, 27);
            this.campoTelefone1.TabIndex = 27;
            // 
            // campoTelefone2
            // 
            this.campoTelefone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoTelefone2.Location = new System.Drawing.Point(229, 458);
            this.campoTelefone2.Margin = new System.Windows.Forms.Padding(2);
            this.campoTelefone2.Name = "campoTelefone2";
            this.campoTelefone2.Size = new System.Drawing.Size(185, 27);
            this.campoTelefone2.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(72, 511);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "Observações:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(229, 511);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(242, 81);
            this.textBox4.TabIndex = 30;
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.botaoCancelar.Location = new System.Drawing.Point(76, 614);
            this.botaoCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(96, 47);
            this.botaoCancelar.TabIndex = 31;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            // 
            // CadastrarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 672);
            this.Controls.Add(this.botaoCancelar);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.campoTelefone2);
            this.Controls.Add(this.campoTelefone1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.campoComplemento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.campoNumero);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.campoBairro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.campoRua);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.campoCPF);
            this.Controls.Add(this.campoDataNascimento);
            this.Controls.Add(this.botaoCadastrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.campoIdade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.campoNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CadastrarPaciente";
            this.Text = "CadastrarPaciente";
            this.Load += new System.EventHandler(this.CadastrarPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button botaoCadastrar;
        private System.Windows.Forms.MaskedTextBox campoDataNascimento;
        private System.Windows.Forms.MaskedTextBox campoCPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoRua;
        private System.Windows.Forms.Label campoIdade;
        private System.Windows.Forms.TextBox campoBairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox campoNumero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox campoComplemento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox campoTelefone1;
        private System.Windows.Forms.TextBox campoTelefone2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button botaoCancelar;
    }
}