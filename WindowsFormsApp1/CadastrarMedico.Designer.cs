namespace WindowsFormsApp1
{
    partial class CadastrarMedico
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
            this.radioBotaoMasculino = new System.Windows.Forms.RadioButton();
            this.radioBotaoFeminino = new System.Windows.Forms.RadioButton();
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
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.campoTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.campoTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.campoRG = new System.Windows.Forms.MaskedTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.campoCRM = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.campoFormacao = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioBotaoMasculino
            // 
            this.radioBotaoMasculino.AutoSize = true;
            this.radioBotaoMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBotaoMasculino.Location = new System.Drawing.Point(384, 36);
            this.radioBotaoMasculino.Margin = new System.Windows.Forms.Padding(2);
            this.radioBotaoMasculino.Name = "radioBotaoMasculino";
            this.radioBotaoMasculino.Size = new System.Drawing.Size(94, 22);
            this.radioBotaoMasculino.TabIndex = 1;
            this.radioBotaoMasculino.Text = "Masculino";
            this.radioBotaoMasculino.UseVisualStyleBackColor = true;
            this.radioBotaoMasculino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioBotaoFeminino
            // 
            this.radioBotaoFeminino.AutoSize = true;
            this.radioBotaoFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBotaoFeminino.Location = new System.Drawing.Point(384, 18);
            this.radioBotaoFeminino.Margin = new System.Windows.Forms.Padding(2);
            this.radioBotaoFeminino.Name = "radioBotaoFeminino";
            this.radioBotaoFeminino.Size = new System.Drawing.Size(87, 22);
            this.radioBotaoFeminino.TabIndex = 2;
            this.radioBotaoFeminino.Text = "Feminino";
            this.radioBotaoFeminino.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // campoNome
            // 
            this.campoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNome.Location = new System.Drawing.Point(69, 23);
            this.campoNome.Margin = new System.Windows.Forms.Padding(2);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(242, 23);
            this.campoNome.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
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
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data Nascimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(274, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Idade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cpf:";
            // 
            // botaoCadastrar
            // 
            this.botaoCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.botaoCadastrar.Location = new System.Drawing.Point(385, 416);
            this.botaoCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.botaoCadastrar.Name = "botaoCadastrar";
            this.botaoCadastrar.Size = new System.Drawing.Size(96, 47);
            this.botaoCadastrar.TabIndex = 14;
            this.botaoCadastrar.Text = "Cadastrar";
            this.botaoCadastrar.UseVisualStyleBackColor = true;
            this.botaoCadastrar.Click += new System.EventHandler(this.botaoCadastrar_Click);
            // 
            // campoDataNascimento
            // 
            this.campoDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoDataNascimento.Location = new System.Drawing.Point(151, 96);
            this.campoDataNascimento.Margin = new System.Windows.Forms.Padding(2);
            this.campoDataNascimento.Mask = "00/00/0000";
            this.campoDataNascimento.Name = "campoDataNascimento";
            this.campoDataNascimento.Size = new System.Drawing.Size(97, 23);
            this.campoDataNascimento.TabIndex = 15;
            this.campoDataNascimento.ValidatingType = typeof(System.DateTime);
            this.campoDataNascimento.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.campoDataNascimento_TypeValidationCompleted);
            // 
            // campoCPF
            // 
            this.campoCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.campoCPF.Location = new System.Drawing.Point(69, 62);
            this.campoCPF.Margin = new System.Windows.Forms.Padding(2);
            this.campoCPF.Mask = "000.000.000-00";
            this.campoCPF.Name = "campoCPF";
            this.campoCPF.Size = new System.Drawing.Size(122, 23);
            this.campoCPF.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Rua:";
            // 
            // campoRua
            // 
            this.campoRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoRua.Location = new System.Drawing.Point(69, 132);
            this.campoRua.Margin = new System.Windows.Forms.Padding(2);
            this.campoRua.Name = "campoRua";
            this.campoRua.Size = new System.Drawing.Size(213, 23);
            this.campoRua.TabIndex = 18;
            // 
            // campoIdade
            // 
            this.campoIdade.AutoSize = true;
            this.campoIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoIdade.Location = new System.Drawing.Point(325, 99);
            this.campoIdade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.campoIdade.Name = "campoIdade";
            this.campoIdade.Size = new System.Drawing.Size(48, 17);
            this.campoIdade.TabIndex = 12;
            this.campoIdade.Text = "          ";
            // 
            // campoBairro
            // 
            this.campoBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoBairro.Location = new System.Drawing.Point(350, 135);
            this.campoBairro.Margin = new System.Windows.Forms.Padding(2);
            this.campoBairro.Name = "campoBairro";
            this.campoBairro.Size = new System.Drawing.Size(181, 23);
            this.campoBairro.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(296, 135);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Bairro:";
            // 
            // campoNumero
            // 
            this.campoNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoNumero.Location = new System.Drawing.Point(83, 177);
            this.campoNumero.Margin = new System.Windows.Forms.Padding(2);
            this.campoNumero.Name = "campoNumero";
            this.campoNumero.Size = new System.Drawing.Size(53, 23);
            this.campoNumero.TabIndex = 22;
            this.campoNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.somenteNumero);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 177);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Número:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(150, 177);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Complemento:";
            // 
            // campoComplemento
            // 
            this.campoComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoComplemento.Location = new System.Drawing.Point(252, 177);
            this.campoComplemento.Margin = new System.Windows.Forms.Padding(2);
            this.campoComplemento.Name = "campoComplemento";
            this.campoComplemento.Size = new System.Drawing.Size(279, 23);
            this.campoComplemento.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 223);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Telefone 1:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(274, 226);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Telefone 2:";
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.botaoCancelar.Location = new System.Drawing.Point(76, 416);
            this.botaoCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(96, 47);
            this.botaoCancelar.TabIndex = 31;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = "";
            this.panel1.AccessibleName = "";
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.campoFormacao);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.campoCRM);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.campoTelefone1);
            this.panel1.Controls.Add(this.campoTelefone2);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 385);
            this.panel1.TabIndex = 34;
            // 
            // campoTelefone1
            // 
            this.campoTelefone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.campoTelefone1.Location = new System.Drawing.Point(99, 207);
            this.campoTelefone1.Margin = new System.Windows.Forms.Padding(2);
            this.campoTelefone1.Mask = "(00)00000-0000";
            this.campoTelefone1.Name = "campoTelefone1";
            this.campoTelefone1.Size = new System.Drawing.Size(122, 23);
            this.campoTelefone1.TabIndex = 47;
            // 
            // campoTelefone2
            // 
            this.campoTelefone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.campoTelefone2.Location = new System.Drawing.Point(357, 210);
            this.campoTelefone2.Margin = new System.Windows.Forms.Padding(2);
            this.campoTelefone2.Mask = "(00)00000-0000";
            this.campoTelefone2.Name = "campoTelefone2";
            this.campoTelefone2.Size = new System.Drawing.Size(122, 23);
            this.campoTelefone2.TabIndex = 46;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label15.Location = new System.Drawing.Point(487, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 12);
            this.label15.TabIndex = 35;
            this.label15.Text = "Medico";
            // 
            // campoRG
            // 
            this.campoRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.campoRG.Location = new System.Drawing.Point(321, 61);
            this.campoRG.Margin = new System.Windows.Forms.Padding(2);
            this.campoRG.Mask = "00.000.000-0";
            this.campoRG.Name = "campoRG";
            this.campoRG.Size = new System.Drawing.Size(105, 23);
            this.campoRG.TabIndex = 38;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(268, 64);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(33, 17);
            this.label22.TabIndex = 37;
            this.label22.Text = "RG:";
            // 
            // campoEmail
            // 
            this.campoEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoEmail.Location = new System.Drawing.Point(85, 260);
            this.campoEmail.Margin = new System.Windows.Forms.Padding(2);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(446, 23);
            this.campoEmail.TabIndex = 44;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 250);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 17);
            this.label14.TabIndex = 43;
            this.label14.Text = "Email:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(242, 165);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 17);
            this.label13.TabIndex = 48;
            this.label13.Text = "Email:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(342, 320);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 17);
            this.label16.TabIndex = 49;
            this.label16.Text = "CRM:";
            // 
            // campoCRM
            // 
            this.campoCRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.campoCRM.Location = new System.Drawing.Point(387, 317);
            this.campoCRM.Margin = new System.Windows.Forms.Padding(2);
            this.campoCRM.Mask = "(00)00000-0000";
            this.campoCRM.Name = "campoCRM";
            this.campoCRM.Size = new System.Drawing.Size(131, 23);
            this.campoCRM.TabIndex = 50;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.Control;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(10, 318);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 17);
            this.label17.TabIndex = 51;
            this.label17.Text = "Formação:";
            // 
            // campoFormacao
            // 
            this.campoFormacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoFormacao.Location = new System.Drawing.Point(86, 289);
            this.campoFormacao.Margin = new System.Windows.Forms.Padding(2);
            this.campoFormacao.Multiline = true;
            this.campoFormacao.Name = "campoFormacao";
            this.campoFormacao.Size = new System.Drawing.Size(255, 82);
            this.campoFormacao.TabIndex = 52;
            // 
            // CadastrarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 474);
            this.Controls.Add(this.campoEmail);
            this.Controls.Add(this.campoRG);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.botaoCancelar);
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
            this.Controls.Add(this.radioBotaoFeminino);
            this.Controls.Add(this.radioBotaoMasculino);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CadastrarMedico";
            this.Text = "CadastrarMedico";
            this.Load += new System.EventHandler(this.CadastrarMedico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBotaoMasculino;
        private System.Windows.Forms.RadioButton radioBotaoFeminino;
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
        private System.Windows.Forms.Button botaoCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox campoRG;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox campoTelefone1;
        private System.Windows.Forms.MaskedTextBox campoTelefone2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox campoCRM;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox campoFormacao;
    }
}