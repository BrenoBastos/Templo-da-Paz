
namespace WindowsFormsApp1
{
    partial class AlterarL
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bAlterar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Num_Registro_Profissional = new System.Windows.Forms.Label();
            this.mNum = new System.Windows.Forms.MaskedTextBox();
            this.Estado = new System.Windows.Forms.Label();
            this.cEstado = new System.Windows.Forms.ComboBox();
            this.bVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lSenha
            // 
            this.lSenha.ActiveLinkColor = System.Drawing.Color.Black;
            this.lSenha.AutoSize = true;
            this.lSenha.LinkColor = System.Drawing.Color.Black;
            this.lSenha.Location = new System.Drawing.Point(589, 142);
            this.lSenha.Name = "lSenha";
            this.lSenha.Size = new System.Drawing.Size(73, 13);
            this.lSenha.TabIndex = 51;
            this.lSenha.TabStop = true;
            this.lSenha.Text = "MostrarSenha";
            this.lSenha.VisitedLinkColor = System.Drawing.Color.Black;
            this.lSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lSenha_LinkClicked_1);
            // 
            // textCpf
            // 
            this.textCpf.Location = new System.Drawing.Point(34, 58);
            this.textCpf.Mask = "000.000.000-00";
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(100, 20);
            this.textCpf.TabIndex = 50;
            // 
            // textRG
            // 
            this.textRG.Location = new System.Drawing.Point(47, 98);
            this.textRG.Mask = "00.000.000-0";
            this.textRG.Name = "textRG";
            this.textRG.Size = new System.Drawing.Size(100, 20);
            this.textRG.TabIndex = 49;
            // 
            // mContato
            // 
            this.mContato.Location = new System.Drawing.Point(250, 95);
            this.mContato.Name = "mContato";
            this.mContato.Size = new System.Drawing.Size(100, 20);
            this.mContato.TabIndex = 48;
            // 
            // mDataNascimento
            // 
            this.mDataNascimento.Location = new System.Drawing.Point(241, 65);
            this.mDataNascimento.Mask = "00/00/0000";
            this.mDataNascimento.Name = "mDataNascimento";
            this.mDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.mDataNascimento.TabIndex = 47;
            this.mDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // cSexo
            // 
            this.cSexo.FormattingEnabled = true;
            this.cSexo.Location = new System.Drawing.Point(514, 106);
            this.cSexo.Name = "cSexo";
            this.cSexo.Size = new System.Drawing.Size(121, 21);
            this.cSexo.TabIndex = 46;
            // 
            // cEstadoCivil
            // 
            this.cEstadoCivil.FormattingEnabled = true;
            this.cEstadoCivil.Location = new System.Drawing.Point(514, 72);
            this.cEstadoCivil.Name = "cEstadoCivil";
            this.cEstadoCivil.Size = new System.Drawing.Size(121, 21);
            this.cEstadoCivil.TabIndex = 45;
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(232, 28);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(100, 20);
            this.textEndereco.TabIndex = 44;
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(473, 142);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(100, 20);
            this.textSenha.TabIndex = 43;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(47, 136);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 42;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(47, 27);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(100, 20);
            this.textNome.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-84, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "RG";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Endereço";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "DataNascimento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-79, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "EstadoCivil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Contato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-84, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-84, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nome";
            // 
            // bAlterar
            // 
            this.bAlterar.Location = new System.Drawing.Point(201, 224);
            this.bAlterar.Name = "bAlterar";
            this.bAlterar.Size = new System.Drawing.Size(75, 23);
            this.bAlterar.TabIndex = 29;
            this.bAlterar.Text = "Alterar";
            this.bAlterar.UseVisualStyleBackColor = true;
            this.bAlterar.Click += new System.EventHandler(this.bAlterar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Nome";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "RG";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "CPF";
            // 
            // Num_Registro_Profissional
            // 
            this.Num_Registro_Profissional.AutoSize = true;
            this.Num_Registro_Profissional.Location = new System.Drawing.Point(153, 145);
            this.Num_Registro_Profissional.Name = "Num_Registro_Profissional";
            this.Num_Registro_Profissional.Size = new System.Drawing.Size(133, 13);
            this.Num_Registro_Profissional.TabIndex = 56;
            this.Num_Registro_Profissional.Text = "Num_Registro_Profissional";
            // 
            // mNum
            // 
            this.mNum.Location = new System.Drawing.Point(292, 142);
            this.mNum.Mask = "00/00/0000";
            this.mNum.Name = "mNum";
            this.mNum.Size = new System.Drawing.Size(100, 20);
            this.mNum.TabIndex = 57;
            this.mNum.ValidatingType = typeof(System.DateTime);
            this.mNum.Click += new System.EventHandler(this.mNum_Click);
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(398, 181);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(40, 13);
            this.Estado.TabIndex = 58;
            this.Estado.Text = "Estado";
            // 
            // cEstado
            // 
            this.cEstado.FormattingEnabled = true;
            this.cEstado.Location = new System.Drawing.Point(473, 181);
            this.cEstado.Name = "cEstado";
            this.cEstado.Size = new System.Drawing.Size(121, 21);
            this.cEstado.TabIndex = 59;
            // 
            // bVoltar
            // 
            this.bVoltar.Location = new System.Drawing.Point(34, 233);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(75, 23);
            this.bVoltar.TabIndex = 66;
            this.bVoltar.Text = "Voltar";
            this.bVoltar.UseVisualStyleBackColor = true;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // AlterarL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 450);
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
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAlterar);
            this.Name = "AlterarL";
            this.Text = "AlterarL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAlterar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Num_Registro_Profissional;
        private System.Windows.Forms.MaskedTextBox mNum;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.ComboBox cEstado;
        private System.Windows.Forms.Button bVoltar;
    }
}