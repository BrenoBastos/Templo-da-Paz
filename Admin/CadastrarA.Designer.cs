
namespace WindowsFormsApp1
{
    partial class CadastrarA
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
            this.cStatus = new System.Windows.Forms.ComboBox();
            this.Status = new System.Windows.Forms.Label();
            this.lSenha = new System.Windows.Forms.LinkLabel();
            this.textCpf = new System.Windows.Forms.MaskedTextBox();
            this.textRG = new System.Windows.Forms.MaskedTextBox();
            this.mDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.cSexo = new System.Windows.Forms.ComboBox();
            this.cEstadoCivil = new System.Windows.Forms.ComboBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.bCadastrar = new System.Windows.Forms.Button();
            this.bVoltar = new System.Windows.Forms.Button();
            this.cContato = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mCelular = new System.Windows.Forms.TextBox();
            this.Telefone = new System.Windows.Forms.Label();
            this.Celular = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cStatus
            // 
            this.cStatus.FormattingEnabled = true;
            this.cStatus.Location = new System.Drawing.Point(619, 208);
            this.cStatus.Name = "cStatus";
            this.cStatus.Size = new System.Drawing.Size(121, 21);
            this.cStatus.TabIndex = 87;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(544, 208);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(37, 13);
            this.Status.TabIndex = 86;
            this.Status.Text = "Status";
            // 
            // lSenha
            // 
            this.lSenha.ActiveLinkColor = System.Drawing.Color.Black;
            this.lSenha.AutoSize = true;
            this.lSenha.LinkColor = System.Drawing.Color.Black;
            this.lSenha.Location = new System.Drawing.Point(491, 272);
            this.lSenha.Name = "lSenha";
            this.lSenha.Size = new System.Drawing.Size(73, 13);
            this.lSenha.TabIndex = 85;
            this.lSenha.TabStop = true;
            this.lSenha.Text = "MostrarSenha";
            this.lSenha.VisitedLinkColor = System.Drawing.Color.Black;
            this.lSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lSenha_LinkClicked);
            // 
            // textCpf
            // 
            this.textCpf.Location = new System.Drawing.Point(102, 146);
            this.textCpf.Mask = "000.000.000-00";
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(100, 20);
            this.textCpf.TabIndex = 84;
            this.textCpf.Click += new System.EventHandler(this.textCpf_Click);
            // 
            // textRG
            // 
            this.textRG.Location = new System.Drawing.Point(87, 183);
            this.textRG.Mask = "00.000.000-0";
            this.textRG.Name = "textRG";
            this.textRG.Size = new System.Drawing.Size(100, 20);
            this.textRG.TabIndex = 83;
            this.textRG.Click += new System.EventHandler(this.textRG_Click_1);
            // 
            // mDataNascimento
            // 
            this.mDataNascimento.Location = new System.Drawing.Point(374, 153);
            this.mDataNascimento.Mask = "00/00/0000";
            this.mDataNascimento.Name = "mDataNascimento";
            this.mDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.mDataNascimento.TabIndex = 81;
            this.mDataNascimento.ValidatingType = typeof(System.DateTime);
            this.mDataNascimento.Click += new System.EventHandler(this.mDataNascimento_Click);
            // 
            // cSexo
            // 
            this.cSexo.FormattingEnabled = true;
            this.cSexo.Location = new System.Drawing.Point(631, 169);
            this.cSexo.Name = "cSexo";
            this.cSexo.Size = new System.Drawing.Size(121, 21);
            this.cSexo.TabIndex = 80;
            // 
            // cEstadoCivil
            // 
            this.cEstadoCivil.FormattingEnabled = true;
            this.cEstadoCivil.Location = new System.Drawing.Point(631, 115);
            this.cEstadoCivil.Name = "cEstadoCivil";
            this.cEstadoCivil.Size = new System.Drawing.Size(121, 21);
            this.cEstadoCivil.TabIndex = 79;
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(365, 116);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(100, 20);
            this.textEndereco.TabIndex = 78;
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(365, 286);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(100, 20);
            this.textSenha.TabIndex = 77;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(111, 120);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(100, 20);
            this.textNome.TabIndex = 75;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 74;
            this.label10.Text = "RG";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(311, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 73;
            this.label9.Text = "Endereço";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "DataNascimento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "EstadoCivil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Sexo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "CPF";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(49, 123);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 65;
            this.Nome.Text = "Nome";
            // 
            // bCadastrar
            // 
            this.bCadastrar.Location = new System.Drawing.Point(334, 312);
            this.bCadastrar.Name = "bCadastrar";
            this.bCadastrar.Size = new System.Drawing.Size(75, 23);
            this.bCadastrar.TabIndex = 64;
            this.bCadastrar.Text = "Cadastrar";
            this.bCadastrar.UseVisualStyleBackColor = true;
            this.bCadastrar.Click += new System.EventHandler(this.bCadastrar_Click);
            // 
            // bVoltar
            // 
            this.bVoltar.Location = new System.Drawing.Point(127, 286);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(75, 23);
            this.bVoltar.TabIndex = 88;
            this.bVoltar.Text = "Voltar";
            this.bVoltar.UseVisualStyleBackColor = true;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // cContato
            // 
            this.cContato.FormattingEnabled = true;
            this.cContato.Location = new System.Drawing.Point(374, 183);
            this.cContato.Name = "cContato";
            this.cContato.Size = new System.Drawing.Size(121, 21);
            this.cContato.TabIndex = 101;
            this.cContato.SelectedIndexChanged += new System.EventHandler(this.cContato_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Contato";
            // 
            // mCelular
            // 
            this.mCelular.Location = new System.Drawing.Point(374, 209);
            this.mCelular.Name = "mCelular";
            this.mCelular.Size = new System.Drawing.Size(100, 20);
            this.mCelular.TabIndex = 104;
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Location = new System.Drawing.Point(290, 250);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(49, 13);
            this.Telefone.TabIndex = 103;
            this.Telefone.Text = "Telefone";
            // 
            // Celular
            // 
            this.Celular.AutoSize = true;
            this.Celular.Location = new System.Drawing.Point(300, 216);
            this.Celular.Name = "Celular";
            this.Celular.Size = new System.Drawing.Size(39, 13);
            this.Celular.TabIndex = 102;
            this.Celular.Text = "Celular";
            // 
            // CadastrarA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mCelular);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Celular);
            this.Controls.Add(this.cContato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.cStatus);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.lSenha);
            this.Controls.Add(this.textCpf);
            this.Controls.Add(this.textRG);
            this.Controls.Add(this.mDataNascimento);
            this.Controls.Add(this.cSexo);
            this.Controls.Add(this.cEstadoCivil);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.bCadastrar);
            this.Name = "CadastrarA";
            this.Text = "CadastrarA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cStatus;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.LinkLabel lSenha;
        private System.Windows.Forms.MaskedTextBox textCpf;
        private System.Windows.Forms.MaskedTextBox textRG;
        private System.Windows.Forms.MaskedTextBox mDataNascimento;
        private System.Windows.Forms.ComboBox cSexo;
        private System.Windows.Forms.ComboBox cEstadoCivil;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Button bCadastrar;
        private System.Windows.Forms.Button bVoltar;
        private System.Windows.Forms.ComboBox cContato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mCelular;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.Label Celular;
    }
}