
namespace WindowsFormsApp1
{
    partial class CadastrarL
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
            this.cEstado = new System.Windows.Forms.ComboBox();
            this.Estado = new System.Windows.Forms.Label();
            this.mNum = new System.Windows.Forms.MaskedTextBox();
            this.Num_Registro_Profissional = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lSenha = new System.Windows.Forms.LinkLabel();
            this.textCpf = new System.Windows.Forms.MaskedTextBox();
            this.textRG = new System.Windows.Forms.MaskedTextBox();
            this.mContato = new System.Windows.Forms.MaskedTextBox();
            this.mDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.cSexo = new System.Windows.Forms.ComboBox();
            this.cEstadoCivil = new System.Windows.Forms.ComboBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bCadastrar = new System.Windows.Forms.Button();
            this.bVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cEstado
            // 
            this.cEstado.FormattingEnabled = true;
            this.cEstado.Location = new System.Drawing.Point(542, 269);
            this.cEstado.Name = "cEstado";
            this.cEstado.Size = new System.Drawing.Size(121, 21);
            this.cEstado.TabIndex = 85;
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(467, 269);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(40, 13);
            this.Estado.TabIndex = 84;
            this.Estado.Text = "Estado";
            // 
            // mNum
            // 
            this.mNum.Location = new System.Drawing.Point(361, 230);
            this.mNum.Mask = "00/00/0000";
            this.mNum.Name = "mNum";
            this.mNum.Size = new System.Drawing.Size(100, 20);
            this.mNum.TabIndex = 83;
            this.mNum.ValidatingType = typeof(System.DateTime);
            this.mNum.Click += new System.EventHandler(this.mNum_Click);
            // 
            // Num_Registro_Profissional
            // 
            this.Num_Registro_Profissional.AutoSize = true;
            this.Num_Registro_Profissional.Location = new System.Drawing.Point(222, 233);
            this.Num_Registro_Profissional.Name = "Num_Registro_Profissional";
            this.Num_Registro_Profissional.Size = new System.Drawing.Size(133, 13);
            this.Num_Registro_Profissional.TabIndex = 82;
            this.Num_Registro_Profissional.Text = "Num_Registro_Profissional";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(70, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 81;
            this.label12.Text = "RG";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(75, 220);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 80;
            this.label13.Text = "ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(70, 146);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 79;
            this.label14.Text = "CPF";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(75, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 78;
            this.label11.Text = "Nome";
            // 
            // lSenha
            // 
            this.lSenha.ActiveLinkColor = System.Drawing.Color.Black;
            this.lSenha.AutoSize = true;
            this.lSenha.LinkColor = System.Drawing.Color.Black;
            this.lSenha.Location = new System.Drawing.Point(658, 230);
            this.lSenha.Name = "lSenha";
            this.lSenha.Size = new System.Drawing.Size(73, 13);
            this.lSenha.TabIndex = 77;
            this.lSenha.TabStop = true;
            this.lSenha.Text = "MostrarSenha";
            this.lSenha.VisitedLinkColor = System.Drawing.Color.Black;
            this.lSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lSenha_LinkClicked);
            // 
            // textCpf
            // 
            this.textCpf.Location = new System.Drawing.Point(103, 146);
            this.textCpf.Mask = "000.000.000-00";
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(100, 20);
            this.textCpf.TabIndex = 76;
            this.textCpf.Click += new System.EventHandler(this.textCpf_Click);
            // 
            // textRG
            // 
            this.textRG.Location = new System.Drawing.Point(116, 186);
            this.textRG.Mask = "00.000.000-0";
            this.textRG.Name = "textRG";
            this.textRG.Size = new System.Drawing.Size(100, 20);
            this.textRG.TabIndex = 75;
            this.textRG.Click += new System.EventHandler(this.textRG_Click);
            // 
            // mContato
            // 
            this.mContato.Location = new System.Drawing.Point(319, 183);
            this.mContato.Name = "mContato";
            this.mContato.Size = new System.Drawing.Size(100, 20);
            this.mContato.TabIndex = 74;
            // 
            // mDataNascimento
            // 
            this.mDataNascimento.Location = new System.Drawing.Point(310, 153);
            this.mDataNascimento.Mask = "00/00/0000";
            this.mDataNascimento.Name = "mDataNascimento";
            this.mDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.mDataNascimento.TabIndex = 73;
            this.mDataNascimento.ValidatingType = typeof(System.DateTime);
            this.mDataNascimento.Click += new System.EventHandler(this.mDataNascimento_Click);
            // 
            // cSexo
            // 
            this.cSexo.FormattingEnabled = true;
            this.cSexo.Location = new System.Drawing.Point(583, 194);
            this.cSexo.Name = "cSexo";
            this.cSexo.Size = new System.Drawing.Size(121, 21);
            this.cSexo.TabIndex = 72;
            // 
            // cEstadoCivil
            // 
            this.cEstadoCivil.FormattingEnabled = true;
            this.cEstadoCivil.Location = new System.Drawing.Point(583, 160);
            this.cEstadoCivil.Name = "cEstadoCivil";
            this.cEstadoCivil.Size = new System.Drawing.Size(121, 21);
            this.cEstadoCivil.TabIndex = 71;
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(301, 116);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(100, 20);
            this.textEndereco.TabIndex = 70;
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(542, 230);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(100, 20);
            this.textSenha.TabIndex = 69;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(116, 224);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 68;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(116, 115);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(100, 20);
            this.textNome.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "Endereço";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "DataNascimento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(467, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "EstadoCivil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Contato";
            // 
            // bCadastrar
            // 
            this.bCadastrar.Location = new System.Drawing.Point(270, 312);
            this.bCadastrar.Name = "bCadastrar";
            this.bCadastrar.Size = new System.Drawing.Size(75, 23);
            this.bCadastrar.TabIndex = 60;
            this.bCadastrar.Text = "Cadastrar";
            this.bCadastrar.UseVisualStyleBackColor = true;
            this.bCadastrar.Click += new System.EventHandler(this.bCadastrar_Click);
            // 
            // bVoltar
            // 
            this.bVoltar.Location = new System.Drawing.Point(103, 292);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(75, 23);
            this.bVoltar.TabIndex = 91;
            this.bVoltar.Text = "Voltar";
            this.bVoltar.UseVisualStyleBackColor = true;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // CadastrarL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.cEstado);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.mNum);
            this.Controls.Add(this.Num_Registro_Profissional);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lSenha);
            this.Controls.Add(this.textCpf);
            this.Controls.Add(this.textRG);
            this.Controls.Add(this.mContato);
            this.Controls.Add(this.mDataNascimento);
            this.Controls.Add(this.cSexo);
            this.Controls.Add(this.cEstadoCivil);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bCadastrar);
            this.Name = "CadastrarL";
            this.Text = "CadastrarL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cEstado;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.MaskedTextBox mNum;
        private System.Windows.Forms.Label Num_Registro_Profissional;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel lSenha;
        private System.Windows.Forms.MaskedTextBox textCpf;
        private System.Windows.Forms.MaskedTextBox textRG;
        private System.Windows.Forms.MaskedTextBox mContato;
        private System.Windows.Forms.MaskedTextBox mDataNascimento;
        private System.Windows.Forms.ComboBox cSexo;
        private System.Windows.Forms.ComboBox cEstadoCivil;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bCadastrar;
        private System.Windows.Forms.Button bVoltar;
    }
}